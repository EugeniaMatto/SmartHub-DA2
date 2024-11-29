import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
    standalone: true,
    selector: 'app-notification-form',
    template: `
      <h2>Administrar Notificaciones</h2>
      <p>Selecciona los miembros que recibirán notificaciones:</p>
      <div *ngFor="let member of data.members">
        <mat-checkbox [(ngModel)]="member.selected">
          {{ member.name }} ({{ member.email }})
        </mat-checkbox>
      </div>
      <div class="actions">
        <button mat-stroked-button (click)="onClose()">Cancelar</button>
        <button mat-flat-button color="primary" (click)="onSave()">Guardar</button>
      </div>
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
    imports: [MatCheckboxModule, MatButtonModule, CommonModule, FormsModule]
  })
  export class NotificationFormComponent {
    constructor(
      public dialogRef: MatDialogRef<NotificationFormComponent>,
      @Inject(MAT_DIALOG_DATA) public data: { homeId: string; members: { email: string; name: string; selected: boolean }[] }
    ) {}
  
    onClose(): void {
      this.dialogRef.close();
    }
  
    onSave(): void {
      const selectedEmails = this.data.members
        .filter((member) => member.selected)
        .map((member) => member.email);
      this.dialogRef.close(selectedEmails);
    }
  }
  