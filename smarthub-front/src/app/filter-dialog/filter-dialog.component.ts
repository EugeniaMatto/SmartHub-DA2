import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';

@Component({
  standalone: true,
  selector: 'app-filter-dialog',
  templateUrl: './filter-dialog.component.html',
  styleUrls: ['./filter-dialog.component.scss'],
  imports: [
    CommonModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule
  ]
})
export class FilterDialogComponent {
  selectedType: string;
  selectedRoom: string;
  selectedStatus: string;

  constructor(
    public dialogRef: MatDialogRef<FilterDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.selectedType = data.selectedType || 'all';
    this.selectedRoom = data.selectedRoom || '';
    this.selectedStatus = data.selectedStatus || 'all';
  }

  onApply(): void {
    this.dialogRef.close({
      selectedType: this.selectedType,
      selectedRoom: this.selectedRoom,
      selectedStatus: this.selectedStatus
    });
  }

  onCancel(): void {
    this.dialogRef.close();
  }
}
