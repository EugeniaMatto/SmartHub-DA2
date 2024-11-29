import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ReactiveFormsModule, FormBuilder, FormGroup } from '@angular/forms';
import { HomesService } from '../../core/services/home.service';

@Component({
  standalone: true,
  selector: 'app-room-form',
  template: `
    <h2>Crear Habitacion</h2>
    <form [formGroup]="form" (ngSubmit)="onSubmit()">
      <mat-form-field appearance="fill">
        <mat-label>Nombre</mat-label>
        <input matInput formControlName="room" />
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
export class RoomFormComponent {
  form: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<RoomFormComponent>,
    private fb: FormBuilder,
    private homesService: HomesService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.form = this.fb.group({
        room: '',
    });
  }

  onClose(): void {
    this.dialogRef.close();
  }

  onSubmit(): void {
    if (this.form.valid) {
      const roomData = {
        Room: this.form.value.room,
      };
      console.log('Room data:', roomData);
      this.homesService.addRoom(roomData, this.data.homeId).subscribe({
        next: (response) => {
          console.log('Habitacion agregada:', response);
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error al agregar la habitacion:', error);
        }
      });
    }
  }
}
