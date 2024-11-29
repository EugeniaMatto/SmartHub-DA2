import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ReactiveFormsModule, FormBuilder, FormGroup } from '@angular/forms';
import { HomesService } from '../../core/services/home.service';

@Component({
  standalone: true,
  selector: 'app-home-form',
  template: `
    <h2>Crear Hogar</h2>
    <form [formGroup]="form" (ngSubmit)="onSubmit()">
      <mat-form-field appearance="fill">
        <mat-label>Nombre</mat-label>
        <input matInput formControlName="name" />
      </mat-form-field>
      <mat-form-field appearance="fill">
        <mat-label>Calle</mat-label>
        <input matInput formControlName="street" />
      </mat-form-field>
      <mat-form-field appearance="fill">
        <mat-label>Número</mat-label>
        <input matInput formControlName="streetNumber" />
      </mat-form-field>
      <mat-form-field appearance="fill">
        <mat-label>Latitud</mat-label>
        <input matInput type="number" formControlName="lat" />
      </mat-form-field>
      <mat-form-field appearance="fill">
        <mat-label>Longitud</mat-label>
        <input matInput type="number" formControlName="lon" />
      </mat-form-field>
      <mat-form-field appearance="fill">
        <mat-label>Miembros Máximos</mat-label>
        <input matInput type="number" formControlName="maxMembers" />
      </mat-form-field>
      <div class="actions">
        <button mat-stroked-button type="button" (click)="onClose()">Cancelar</button>
        <button mat-flat-button color="primary" type="submit">Guardar</button>
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
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule
  ]
})
export class HomeFormComponent {
  form: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<HomeFormComponent>,
    private fb: FormBuilder,
    private homesService: HomesService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.form = this.fb.group({
        name: '',
        street: '',
        streetNumber: '',
        lat: null,
        lon: null,
        maxMembers: null
    });
  }

  onClose(): void {
    this.dialogRef.close();
  }

  onSubmit(): void {
    if (this.form.valid) {
      const homeData = {
        Name: this.form.value.name,
        Street: this.form.value.street,
        StreetNumber: this.form.value.streetNumber,
        Ubication: {
          Lat: this.form.value.lat,
          Lon: this.form.value.lon
        },
        MaxMembers: this.form.value.maxMembers
      };
      this.homesService.addHome(homeData).subscribe({
        next: (response) => {
          console.log('Hogar agregado:', response);
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error al agregar el hogar:', error);
        }
      });
    }
  }
}
