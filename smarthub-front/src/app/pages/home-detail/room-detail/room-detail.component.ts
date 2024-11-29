import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { HomesService } from '../../../core/services/home.service';

@Component({
  standalone: true,
  selector: 'app-room-detail',
  templateUrl: './room-detail.component.html',
  styleUrls: ['./room-detail.component.scss'],
  imports: [
    CommonModule,
    MatCardModule,
    MatButtonModule
  ]
})
export class RoomDetailComponent implements OnInit {
  roomName: string | null = null;
  homeId: string | null = null;
  devices: any[] = [];

  constructor(
    private route: ActivatedRoute,
    private homesService: HomesService
  ) {}

  ngOnInit(): void {
    this.roomName = this.route.snapshot.paramMap.get('roomName');
    this.homeId = this.route.snapshot.paramMap.get('homeId');

    if (this.homeId && this.roomName) {
      this.loadRoomDevices(this.homeId, this.roomName);
    }
  }

  loadRoomDevices(homeId: string, roomName: string): void {
    this.homesService.getRoomsByHomeId(homeId).subscribe({
      next: (data) => {
        const room = data[roomName];
        if (room) {
          this.devices = room;
        }
      },
      error: (error) => {
        console.error('Error al cargar los dispositivos de la habitación', error);
      }
    });
  }
}
