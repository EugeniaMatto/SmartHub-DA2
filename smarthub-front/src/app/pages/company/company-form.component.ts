import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { CompanyService } from '../../core/services/company.service';

@Component({
  selector: 'app-company-form',
  standalone: true,
  template: `
    <h2>Agregar Compañía</h2>
    <form [formGroup]="companyForm" (ngSubmit)="onSubmit()">
      <mat-form-field appearance="fill">
        <mat-label>Nombre de la Compañía</mat-label>
        <input matInput formControlName="name" />
        <mat-error *ngIf="companyForm.get('name')?.hasError('required')">El nombre es obligatorio</mat-error>
      </mat-form-field>

      <mat-form-field appearance="fill">
        <mat-label>URL del Logotipo</mat-label>
        <input matInput formControlName="logoUrl" />
        <mat-error *ngIf="companyForm.get('logoUrl')?.hasError('required')">La URL del logo es obligatoria</mat-error>
      </mat-form-field>

      <mat-form-field appearance="fill">
        <mat-label>RUT</mat-label>
        <input matInput formControlName="rut" />
        <mat-error *ngIf="companyForm.get('rut')?.hasError('required')">El RUT es obligatorio</mat-error>
        <mat-error *ngIf="companyForm.get('rut')?.hasError('pattern')">El RUT solo puede contener números</mat-error>
      </mat-form-field>

      <div class="actions">
        <button mat-stroked-button type="button" (click)="dialogRef.close()">Cancelar</button>
        <button mat-flat-button color="primary" type="submit" [disabled]="companyForm.invalid">Guardar</button>
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
export class CompanyFormComponent {
  companyForm: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<CompanyFormComponent>,
    private fb: FormBuilder,
    private companyService: CompanyService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.companyForm = this.fb.group({
      name: ['', [Validators.required]],
      logoUrl: ['', [Validators.required]],
      rut: ['', [Validators.required, Validators.pattern('^\\d+$')]]
    });
  }

  onSubmit(): void {
    if (this.companyForm.valid) {
      this.companyService.createCompany(this.companyForm.value).subscribe({
        next: (response) => {
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error al crear la compañía', error);
        }
      });
    }
  }
}
