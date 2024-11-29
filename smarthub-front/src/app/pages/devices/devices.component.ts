import { Component, ViewChild, AfterViewInit, OnInit } from '@angular/core'; 
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatTableModule, MatTableDataSource } from '@angular/material/table';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';
import { MatPaginatorModule, MatPaginator } from '@angular/material/paginator';
import { FormsModule } from '@angular/forms';
import { DeviceService } from '../../core/services/device.service';
import { AddDeviceDialogComponent } from '../add-device-dialog/add-device-dialog.component';

@Component({
  standalone: true,
  selector: 'app-devices',
  templateUrl: './devices.component.html',
  styleUrls: ['./devices.component.scss'],
  imports: [
    CommonModule,
    MatButtonModule,
    MatCardModule,
    MatTableModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatIconModule,
    FormsModule,
    MatPaginatorModule,
    AddDeviceDialogComponent 
  ]
})
export class DevicesComponent implements AfterViewInit, OnInit {
  user: any = JSON.parse(localStorage.getItem('currentUser') || '{}');
  devices: any[] = [];
  dataSource = new MatTableDataSource<any>();
  errorMessage: string | null = null;
  showFilterOptions: boolean = false;
  deviceTypes: string[] = [];
  showDeviceTypes: boolean = false; 
  selectedNameFilter: string = '';
  selectedModelFilter: string = '';
  selectedTypeFilter: string = '';

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(private dialog: MatDialog, private deviceService: DeviceService) {}

  ngOnInit() {
    this.getDevices();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  getDevices(): void {
    this.deviceService.getDevices().subscribe({
      next: (data: any) => {
        this.devices = data.items;
        if (this.devices && this.devices.length > 0) {
          this.dataSource.data = this.devices;
          this.extractDeviceTypes(); 
        } else {
          this.errorMessage = 'No se encontraron dispositivos disponibles.';
        }
      },
      error: (err: any) => {
        this.errorMessage = 'No se pudo obtener la lista de dispositivos. Por favor, intenta de nuevo.';
        console.error(err);
      }
    });
  }

  extractDeviceTypes(): void {
    this.deviceTypes = [...new Set(this.devices.map(device => device.type))];
  }

  getDeviceTypes(): void {
    this.deviceService.getDeviceTypes().subscribe({
      next: (data: string[]) => {
        this.deviceTypes = data; 
        this.showDeviceTypes = true; 
      },
      error: (err: any) => {
        console.error('Error al obtener los tipos de dispositivos', err);
      }
    });
  }

  toggleFilterOptions(): void {
    this.showFilterOptions = !this.showFilterOptions;
  }

  applyFilters(): void {
    const filteredData = this.devices.filter(device => {
      const matchesType = this.selectedTypeFilter ? device.type === this.selectedTypeFilter : true;
      const matchesName = this.selectedNameFilter ? device.name.toLowerCase().includes(this.selectedNameFilter.toLowerCase()) : true;
      const matchesModel = this.selectedModelFilter ? device.model.toLowerCase().includes(this.selectedModelFilter.toLowerCase()) : true;
      return matchesType && matchesName && matchesModel;
    });
    this.dataSource.data = filteredData;
  }

  openAddDeviceDialog(): void {
    const dialogRef = this.dialog.open(AddDeviceDialogComponent, {
      width: '400px',
    });
  
    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        const body: any = {
          Name: result.name,
          ModelNumber: result.modelNumber,
          Description: result.description,
          Photos: result.photos,
        };
  
        if (result.type === 'cameras') {
          body.UseTypes = result.useTypes;
          body.SupportedActions = result.supportedActions;
        }
  
        this.deviceService.sendDeviceData(result.type, body).subscribe({
          next: (response) => {
            console.log('Dispositivo agregado exitosamente:', response);
            this.getDevices();
          },
          error: (error) => {
            console.error('Error al agregar el dispositivo:', error);
          },
        });
      }
    });
  }
}
