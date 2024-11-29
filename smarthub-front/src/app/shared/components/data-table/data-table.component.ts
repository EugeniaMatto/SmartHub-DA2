import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';

interface TableColumn {
  columnDef: string;
  header: string;
  cell: (element: any) => string;
}

@Component({
  selector: 'app-data-table',
  standalone: true,
  imports: [CommonModule, MatTableModule, MatButtonModule, MatIconModule, MatTooltipModule],
  template: `
    <table mat-table [dataSource]="data" *ngIf="data && data.length > 0">
      <ng-container *ngFor="let column of columns" [matColumnDef]="column.columnDef">
        <th mat-header-cell *matHeaderCellDef> {{ column.header }} </th>
        <td mat-cell *matCellDef="let element"> {{ column.cell(element) }} </td>
      </ng-container>
      <ng-container matColumnDef="actions">
        <th mat-header-cell *matHeaderCellDef> Acciones </th>
        <td mat-cell *matCellDef="let element">
          <ng-container *ngIf="showDeleteCondition && showDeleteCondition(element)">
            <button mat-icon-button color="warn" (click)="delete.emit(element)">
              <mat-icon>delete</mat-icon>
            </button>
          </ng-container>
          <ng-container *ngIf="edit.observers.length > 0">
            <button mat-icon-button color="primary" matTooltip="Editar permisos del usuario" (click)="edit.emit(element)">
              <mat-icon>edit</mat-icon>
            </button>
          </ng-container>
        </td>
      </ng-container>

      <tr mat-header-row *matHeaderRowDef="displayedColumnDefs"></tr>
      <tr mat-row *matRowDef="let row; columns: displayedColumnDefs;"></tr>
    </table>
  `,
  styleUrls: ['./data-table.component.scss']
})
export class DataTableComponent {
  @Input() data: any[] = [];
  @Input() columns: TableColumn[] = [];
  @Input() showDeleteCondition?: (element: any) => boolean;
  @Output() delete = new EventEmitter<any>();
  @Output() edit = new EventEmitter<any>();

  get displayedColumnDefs(): string[] {
    return [...this.columns.map(col => col.columnDef), 'actions'];
  }
}
