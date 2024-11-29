import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { ReactiveFormsModule, FormBuilder, FormGroup } from '@angular/forms';

import { CommonModule } from '@angular/common';
import { DeviceService } from '../../../core/services/device.service';

@Component({
  standalone: true,
  selector: 'app-device-to-room-form',
  template: `
    <h2>Agregar Dispositivo a la Habitación {{ data.room }}</h2>
    <form [formGroup]="form" (ngSubmit)="onSubmit()">
      <mat-form-field appearance="fill" *ngIf="devices && devices.length > 0; else noDevices">
        <mat-label>Seleccionar Dispositivo</mat-label>
        <mat-select formControlName="device">
          <mat-option *ngFor="let device of devices" [value]="device.id">
            {{ device.name }}
          </mat-option>
        </mat-select>
      </mat-form-field>
      <ng-template #noDevices>
        <p>No hay dispositivos disponibles. Primero crea uno.</p>
        <a mat-button color="primary" routerLink="/devices">Ir a dispositivos</a>
      </ng-template>

      <div class="actions">
        <button mat-stroked-button type="button" (click)="onClose()">Cancelar</button>
        <button mat-flat-button color="primary" type="submit" [disabled]="devices.length === 0">Guardar</button>
      </div>
    </form>
  `,
  styles: [
    `
      .actions {
        display: flex;
        justify-content: flex-end;
        gap: 8px;
      }
    `
  ],
  imports: [
    CommonModule,
    MatButtonModule,
    MatFormFieldModule,
    MatSelectModule,
    ReactiveFormsModule
  ]
})
export class DeviceToRoomFormComponent implements OnInit {
  form: FormGroup;
  devices: any[] = [];

  constructor(
    public dialogRef: MatDialogRef<DeviceToRoomFormComponent>,
    private fb: FormBuilder,
    private deviceService: DeviceService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.form = this.fb.group({
      device: ''
    });
  }

  ngOnInit(): void {
    this.deviceService.getDevices().subscribe({
      next: (devices) => {
        this.devices = devices.items; 
      },
      error: (error) => {
        console.error('Error al cargar los dispositivos', error);
      }
    });
  }

  onClose(): void {
    this.dialogRef.close();
  }

  onSubmit(): void {
    if (this.form.valid) {
      const selectedDevice = {
        Room: this.data.room,
        DeviceId: this.form.value.device
      };
      this.dialogRef.close(selectedDevice);
    }
  }
}
