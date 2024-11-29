import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { CommonModule } from '@angular/common';
import { MatSnackBar } from '@angular/material/snack-bar';
import { HomesService } from '../../core/services/home.service';
import { DeviceService } from '../../core/services/device.service';
import { RoomFormComponent } from './room-form.component';
import { FormsModule } from '@angular/forms'; 
import { NotificationFormComponent } from './notification-form.component';
import {DeviceDetailDialogComponent} from './device-detail-dialog.component';
import { MatTooltipModule } from '@angular/material/tooltip';

@Component({
  standalone: true,
  selector: 'app-home-detail',
  templateUrl: './home-detail.component.html',
  styleUrls: ['./home-detail.component.scss'],
  imports: [
    CommonModule,
    MatCardModule,
    MatButtonModule,
    FormsModule,
    MatTooltipModule
  ]
})
export class HomeDetailComponent implements OnInit {
  home: any;
  rooms: any[] = [];
  devices: any[] = [];
  allDevices: any[] = []; 
  showDevicesToAdd: boolean = false;
  selectedRoom: string | null = null;
  homeMembers: any[] = [];
  user: any = JSON.parse(localStorage.getItem('currentUser') || '{}');

  constructor(
    private route: ActivatedRoute,
    private homesService: HomesService,
    private dialog: MatDialog,
    private deviceService: DeviceService,
    private homeService: HomesService,
    private snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    const homeId = this.route.snapshot.paramMap.get('homeId');
    if (homeId) {
      this.homesService.getHomeById(homeId).subscribe({
        next: (data) => (this.home = data),
        error: (error) => console.error('Error al cargar los detalles del hogar', error)
      });
    }
    this.loadRooms();
    this.loadDevices(); 
  }

  loadRooms(): void {
    const homeId = this.route.snapshot.paramMap.get('homeId') ?? '';
    this.homesService.getRoomsByHomeId(homeId).subscribe({
      next: (data) => {
        this.rooms = Object.entries(data).map(([roomName, devices]) => ({
          name: roomName,
          devices: devices
        }));
        this.updateAllDevices();
      },
      error: (error) => {
        console.error('Error al cargar las habitaciones', error);
      }
    });
  }

  loadHomeMembers(): void {
    this.homeService.getHomes().subscribe(homes => {
      const homeMembersList: any[] = [];
      homes.forEach(homeObj => {
        const homeId = homeObj.home.id;
                
        if (homeId) { 
          this.homeService.getHomeMembers(homeId).subscribe(members => {
            const membersWithHomeName = members.map((member: any) => ({
              ...member,
              homeName: homeObj.home.name,
              homeId: homeObj.home.id
            }));          
            homeMembersList.push(...membersWithHomeName);
            this.homeMembers = homeMembersList;
            console.log('Miembros de la casa:', this.homeMembers);
          });
        } else {
          console.warn('El home no tiene un ID válido:', homeObj);
        }
      });
    });
  }  

  loadDevices(): void {
    this.deviceService.getDevices().subscribe({
      next: (data) => {
        this.devices = data.items;
      },
      error: (error) => {
        console.error('Error al cargar los dispositivos', error);
      }
    });
  }

  updateAllDevices(): void {
    this.allDevices = this.rooms.flatMap(room => room.devices);
  }

  openRoomForm(): void {
    const homeId = this.route.snapshot.paramMap.get('homeId');
    const dialogRef = this.dialog.open(RoomFormComponent, {
      width: '400px',
      data: { homeId: homeId }
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadRooms();
      }
    });
  }

  openDevicetoRoomForm(room: any): void {
    this.selectedRoom = room.name;
    this.showDevicesToAdd = true; 
  }

  addDeviceToRoom(deviceId: string, newDeviceName: string): void {
    if (!newDeviceName || newDeviceName.trim() === '') {
      alert('Debe proporcionar un nuevo nombre para el dispositivo.');
      return;
    }
  
    const homeId = this.route.snapshot.paramMap.get('homeId');
    if (homeId && this.selectedRoom) {
      const payload = {
        Room: this.selectedRoom,
        DeviceId: deviceId,
        Name: newDeviceName 
      };
  
      this.homesService.addDeviceToRoom(homeId, payload).subscribe({
        next: () => {
          this.loadRooms(); 
          this.showDevicesToAdd = false; 
        },
        error: (error) => {
          console.error('Error al agregar el dispositivo', error);
        }
      });
    } else {
      console.error('El homeId o la habitación seleccionada no están disponibles.');
    }
  }
  changeDeviceRoom(device: any): void {
    const homeId = this.route.snapshot.paramMap.get('homeId');
    if (!homeId) {
      console.error('El homeId no está disponible.');
      return;
    }
  
    if (!device.selectedRoom || device.selectedRoom.trim() === '') {
      alert('Debe seleccionar una habitación válida para cambiar el dispositivo.');
      return;
    }
  
    const payload = {
      Room: device.selectedRoom,
      HardwareId: device.id
    };
  
    this.homesService.changeDeviceRoom(homeId, payload).subscribe({
      next: () => {
        console.log(`El dispositivo ${device.name} fue movido a la habitación ${device.selectedRoom}.`);
        this.loadRooms(); 
      },
      error: (error) => {
        console.error('Error al cambiar la habitación del dispositivo', error);
      }
    });
  }
  

  openNotificationForm(): void {
    const homeId = this.route.snapshot.paramMap.get('homeId');
    if (homeId) {
      this.homesService.getHomeMembers(homeId).subscribe({
        next: (members) => {
          const currentUser = {
            email: this.user.email,
            name: `${this.user.name}`,
            selected: false
          };
  
          const dialogRef = this.dialog.open(NotificationFormComponent, {
            width: '400px',
            data: {
              homeId: homeId,
              members: [currentUser, ...members.map((member: any) => ({
                email: member.email,
                name: member.name,
                selected: false
              }))]
            }
          });
  
          dialogRef.afterClosed().subscribe((selectedEmails: string[] | null) => {
            if (selectedEmails) {
              this.homesService.addNotificationPermissions(homeId, selectedEmails).subscribe({
                next: () => {
                  this.snackBar.open('Notificaciones asignadas correctamente', 'Cerrar', {
                    duration: 3000,
                    horizontalPosition: 'center',
                    verticalPosition: 'top'
                  });
                },
                error: (error) => {
                  this.snackBar.open('Error al asignar notificaciones', 'Cerrar', {
                    duration: 3000,
                    horizontalPosition: 'center',
                    verticalPosition: 'top'
                  });
                  console.error('Error al asignar notificaciones:', error);
                }
              });
            }
          });
        },
        error: (error) => {
          console.error('Error al obtener miembros del hogar:', error);
        }
      });
    }
  }
    
  closeDeviceForm(): void {
    this.showDevicesToAdd = false; 
  }

  toggleDevicePower(device: any, powerOn: boolean): void {
    const homeId = this.route.snapshot.paramMap.get('homeId');
    if (!homeId) {
      console.error('El homeId no está disponible.');
      return;
    }

    if (powerOn) {
      this.homesService.turnDeviceOn(homeId, device.id).subscribe({
        next: () => {
          console.log(`El dispositivo ${device.name} fue encendido.`);
        },
        error: (error) => {
          if (error?.error?.innerCode === 'InvalidOperation') {
            alert(`El dispositivo ${device.name} ya está encendido.`);
          } else {
            console.error('Error al encender el dispositivo', error);
          }
        }
      });
    } else {
      this.homesService.turnDeviceOff(homeId, device.id).subscribe({
        next: () => {
          console.log(`El dispositivo ${device.name} fue apagado.`);
        },
        error: (error) => {
          if (error?.error?.innerCode === 'InvalidOperation') {
            alert(`El dispositivo ${device.name} ya está apagado.`);
          } else {
            console.error('Error al apagar el dispositivo', error);
          }
        }
      });
    }
  }
  openDeviceDetail(device: any): void {
    this.dialog.open(DeviceDetailDialogComponent, {
      width: '400px',
      data: {
        name: device.name,
        model: device.deviceInfo.model,
        description: device.deviceInfo.description,
        type: device.deviceInfo.type,
        useTypes: device.useTypes,
        supportedActions: device.supportedActions,
        companyName: device.deviceInfo.companyName,
        photos: device.deviceInfo.photos,
        originalName: device.deviceInfo.name,
        online: device.online,
        isOn: device.isOn,
        isOpen: device.isOpen
      },
    });
  }
}
