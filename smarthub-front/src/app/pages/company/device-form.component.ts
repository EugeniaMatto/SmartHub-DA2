import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CompanyService } from '../../core/services/company.service';

@Component({
  selector: 'app-device-form',
  standalone: true,
  template: `
    <h2>Agregar Dispositivo</h2>
    <form [formGroup]="deviceForm" (ngSubmit)="onSubmit()">
      <mat-form-field appearance="fill">
        <mat-label>Nombre del Dispositivo</mat-label>
        <input matInput formControlName="name" />
        <mat-error *ngIf="deviceForm.get('name')?.hasError('required')">El nombre es obligatorio</mat-error>
      </mat-form-field>

      <mat-form-field appearance="fill">
        <mat-label>Modelo</mat-label>
        <input matInput formControlName="model" />
        <mat-error *ngIf="deviceForm.get('model')?.hasError('required')">El modelo es obligatorio</mat-error>
      </mat-form-field>

      <mat-form-field appearance="fill">
        <mat-label>Descripción</mat-label>
        <textarea matInput formControlName="description"></textarea>
        <mat-error *ngIf="deviceForm.get('description')?.hasError('required')">La descripción es obligatoria</mat-error>
      </mat-form-field>

      <mat-form-field appearance="fill">
        <mat-label>Fotografías (URL separadas por comas)</mat-label>
        <input matInput formControlName="photos" />
        <mat-error *ngIf="deviceForm.get('photos')?.hasError('required')">Al menos una foto es obligatoria</mat-error>
      </mat-form-field>

      <div class="actions">
        <button mat-stroked-button type="button" (click)="dialogRef.close()">Cancelar</button>
        <button mat-flat-button color="primary" type="submit" [disabled]="deviceForm.invalid">Guardar</button>
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

      mat-form-field {
        width: 100%;
        margin-bottom: 16px;
      }
    `
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ]
})
export class DeviceFormComponent {
  deviceForm: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<DeviceFormComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private fb: FormBuilder,
    private companyService: CompanyService
  ) {
    this.deviceForm = this.fb.group({
      name: ['', [Validators.required]],
      model: ['', [Validators.required]],
      description: ['', [Validators.required]],
      photos: ['', [Validators.required]]
    });
  }

  onSubmit(): void {
    if (this.deviceForm.valid) {
      const deviceData = {
        ...this.deviceForm.value,
        companyId: this.data.companyId 
      };

      this.companyService.addDeviceToCompany(deviceData).subscribe({
        next: (response) => {
          console.log('Dispositivo agregado:', response);
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error al agregar el dispositivo', error);
        }
      });
    }
  }
}
