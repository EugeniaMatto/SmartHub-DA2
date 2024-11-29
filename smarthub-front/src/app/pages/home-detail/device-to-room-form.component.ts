import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { ReactiveFormsModule, FormBuilder, FormGroup } from '@angular/forms';
import { HomesService } from '../../core/services/home.service';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { DeviceService } from '../../core/services/device.service';

@Component({
  standalone: true,
  selector: 'app-devicetoroom-form',
  template: `
    <h2>Agregar Dispositivo a la Habitacion</h2>
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
      .no-devices {
        margin-top: 1em;
        color: red;
      }
    `
  ],
  imports: [
    CommonModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    RouterModule
  ]
})
export class DeviceToRoomFormComponent implements OnInit {
  form: FormGroup;
  devices: any[] = [];

  constructor(
    public dialogRef: MatDialogRef<DeviceToRoomFormComponent>,
    private fb: FormBuilder,
    private homesService: HomesService,
    private deviceService: DeviceService,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) {
    this.form = this.fb.group({
      device: ''
    });
  }

  ngOnInit(): void {
    this.deviceService.getDevices().subscribe({
      next: (devices) => {
        this.devices = devices;
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
      const roomData = {
        Room: this.data.room,
        DeviceId: this.form.value.device
      };
      console.log('Room data:', roomData);
      this.homesService.addRoom(roomData, this.data.homeId).subscribe({
        next: (response) => {
          console.log('Dispositivo agregado:', response);
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error al agregar el dispositivo:', error);
        }
      });
    }
  }
}
