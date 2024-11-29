import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-notification-details-modal',
  template: `
    <h1 mat-dialog-title>Detalles de la Notificación</h1>
    <div mat-dialog-content>
      <p>{{ data.event }}</p>
      <p><strong>Estado:</strong> {{ data.seen ? 'Visto' : 'No visto' }}</p>
      <div *ngIf="data.photos?.length">
        <h3>Fotos:</h3>
        <div class="photo-container">
          <img *ngFor="let photo of data.photos" [src]="photo" alt="Foto de Notificación" />
        </div>
      </div>
    </div>
    <div mat-dialog-actions>
      <button mat-stroked-button type="button" (click)="markAsSeen()">Marcar como Visto</button>
      <button mat-flat-button color="primary" (click)="onClose()">Cerrar</button>
    </div>
  `,
  styles: [`
    .photo-container {
      display: flex;
      flex-wrap: wrap;
      gap: 8px;
    }
    img {
      max-width: 100px;
      max-height: 100px;
      border-radius: 4px;
      object-fit: cover;
    }
  `],
  imports: [
    MatButtonModule,
    CommonModule
  ]
})
export class NotificationDetailsModalComponent {
  constructor(
    public dialogRef: MatDialogRef<NotificationDetailsModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { id: string; event: string; seen: boolean; photos?: string[] }
  ) {}

  markAsSeen(): void {
    if (!this.data.seen) {
      this.data.seen = true;
      console.log(`Notificación ${this.data.id} marcada como vista.`);
    }
  }

  onClose(): void {
    this.dialogRef.close(this.data);
  }
}
