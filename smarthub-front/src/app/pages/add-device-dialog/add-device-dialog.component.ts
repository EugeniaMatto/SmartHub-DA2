import { Component } from '@angular/core';
import { MatDialogRef, MatDialogModule } from '@angular/material/dialog'; // Añadir MatDialogModule
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';

@Component({
  standalone: true,
  selector: 'app-add-device-dialog',
  templateUrl: './add-device-dialog.component.html',
  styleUrls: ['./add-device-dialog.component.scss'],
  imports: [
    CommonModule,
    MatDialogModule, // IMPORTAR MatDialogModule AQUÍ
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatButtonModule,
    FormsModule
  ]
})
export class AddDeviceDialogComponent {
  deviceType: string = '';
  name: string = '';
  modelNumber: string = '';
  description: string = '';
  photos: string = '';

  // Campos adicionales para cámaras
  useTypes: string[] = []; // Aquí se guardarán los tipos de uso seleccionados
  supportedActions: string[] = []; // Aquí se guardarán las acciones soportadas seleccionadas

  constructor(public dialogRef: MatDialogRef<AddDeviceDialogComponent>) {}

  onAddDevice(): void {
    const newDevice = {
      type: this.deviceType,
      name: this.name,
      modelNumber: this.modelNumber,
      description: this.description,
      photos: this.photos.split(','),
      useTypes: this.useTypes,
      supportedActions: this.supportedActions
    };
    this.dialogRef.close(newDevice);
  }

  onCancel(): void {
    this.dialogRef.close();
  }
}
