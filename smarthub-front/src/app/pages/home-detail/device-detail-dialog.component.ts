import { Component, Inject } from '@angular/core';
import { MatDialogModule } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';

@Component({
  standalone: true,
  selector: 'app-device-detail-dialog',
  template: `
    <h2 mat-dialog-title>Detalles del Dispositivo</h2>
    <mat-dialog-content>
      <p><strong>Nombre:</strong> {{ data.name }}</p>
      <p><strong>Modelo:</strong> {{ data.model }}</p>
      <p><strong>Descripción:</strong> {{ data.description }}</p>
      <p><strong>Tipo:</strong> {{ data.type }}</p>
      <p *ngIf="data.useTypes"><strong>Tipos de Uso:</strong> {{ data.useTypes.join(', ') }}</p>
      <p *ngIf="data.supportedActions"><strong>Acciones Soportadas:</strong> {{ data.supportedActions.join(', ') }}</p>

      <div class="status" [ngClass]="{ 'online': data.online, 'offline': !data.online }">
        <mat-icon *ngIf="data.online" color="primary">check_circle</mat-icon>
        <mat-icon *ngIf="!data.online" color="warn">highlight_off</mat-icon>
        <span>{{ data.online ? 'ESTÁ PRENDIDO' : 'APAGADO' }}</span>
      </div>

      <div *ngIf="data.type === 'SmartLamp'" class="additional-status">
        <p><strong>Estado:</strong> {{ data.isOn ? 'ENCENDIDA' : 'APAGADA' }}</p>
      </div>

      <div *ngIf="data.type === 'WindowSensor'" class="additional-status">
        <p><strong>Estado:</strong> {{ data.isOpen ? 'ABIERTA' : 'CERRADA' }}</p>
      </div>

      <div class="photos" *ngIf="data.photos?.length">
        <h3>Fotos</h3>
        <div class="thumbnail-container">
          <img *ngFor="let photo of data.photos" [src]="photo" alt="Foto del dispositivo" class="thumbnail" />
        </div>
      </div>
    </mat-dialog-content>
    <mat-dialog-actions align="end">
      <button mat-stroked-button mat-dialog-close>Cerrar</button>
    </mat-dialog-actions>
  `,
  styles: [
    `
      mat-dialog-content {
        font-size: 14px;
      }

      mat-dialog-actions {
        margin-top: 20px;
      }

      .status {
        display: flex;
        align-items: center;
        margin: 16px 0;
      }

      .status.online {
        color: green;
      }

      .status.offline {
        color: red;
      }

      .additional-status {
        margin: 8px 0;
        font-weight: bold;
      }

      .photos {
        margin-top: 20px;
      }

      .thumbnail-container {
        display: flex;
        gap: 8px;
        flex-wrap: wrap;
      }

      .thumbnail {
        width: 80px;
        height: 80px;
        object-fit: cover;
        border: 1px solid #ccc;
        border-radius: 4px;
      }
    `,
  ],
  imports: [MatDialogModule, CommonModule, MatButtonModule, MatIconModule],
})
export class DeviceDetailDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<DeviceDetailDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}
}
