import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';

interface DialogField {
  name: string;
  label: string;
  type: string;
  options?: { value: string; label: string; checked?: boolean }[];
  validators?: any[];
}

@Component({
  standalone: true,
  selector: 'app-add-user-form',
  template: `
    <h2>{{ data.title }}</h2>
    <form [formGroup]="form" (ngSubmit)="onSubmit()">
    <ng-container *ngFor="let field of data.fields">
      <mat-form-field appearance="fill" *ngIf="field.type !== 'checkboxes'">
        <mat-label>{{ field.label }}</mat-label>
        <ng-container [ngSwitch]="field.type">
          <input *ngSwitchCase="'text'" matInput [type]="field.type" [formControlName]="field.name" />
          <mat-select *ngSwitchCase="'select'" [formControlName]="field.name">
            <mat-option *ngFor="let option of field.options" [value]="option.value">
              {{ option.label }}
            </mat-option>
          </mat-select>
          <input *ngSwitchCase="'email'" matInput type="email" [formControlName]="field.name" />
          <input *ngSwitchCase="'password'" matInput type="password" [formControlName]="field.name" />
        </ng-container>
      </mat-form-field>

      <div *ngIf="field.type === 'checkboxes'" [formGroupName]="field.name">
        <label>{{ field.label }}</label>
        <div *ngFor="let option of field.options">
          <mat-checkbox [formControlName]="option.value">
            {{ option.label }}
          </mat-checkbox>
        </div>
      </div>
    </ng-container>
      <div class="actions">
        <button mat-stroked-button type="button" (click)="onClose()">Cancelar</button>
        <button mat-flat-button color="primary" type="submit" [disabled]="form.invalid">Guardar</button>
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
    MatSelectModule,
    ReactiveFormsModule,
    CommonModule,
    MatCheckboxModule
  ]
})
export class AddAdminFormComponent implements OnInit {
  form: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<AddAdminFormComponent>,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: { title: string; fields: DialogField[]; serviceMethod: (formData: any) => Observable<any> }
  ) {
    this.form = this.fb.group({});
  }
  

  ngOnInit(): void {
    const controls = this.data.fields.reduce((acc: { [key: string]: any }, field) => {
      if (field.type === 'checkboxes' && field.options) {
        acc[field.name] = this.fb.group(
          field.options.reduce((optionAcc: { [key: string]: boolean }, option) => {
            if (option.value) {
              optionAcc[option.value] = !!option.checked;
            }
            return optionAcc;
          }, {})
        );
      } else {
        acc[field.name] = ['', field.validators || []];
      }
      return acc;
    }, {});
  
    this.form = this.fb.group(controls);
  }
  

  onCheckboxChange(event: any, controlName: string, value: string): void {
    const control = this.form.get(controlName);
    if (!control) return;
  
    const currentValue = control.value || [];
    if (event.checked) {
      control.setValue([...currentValue, value]);
    } else {
      control.setValue(currentValue.filter((item: string) => item !== value));
    }
  }

  onClose(): void {
    this.dialogRef.close();
  }

  onSubmit(): void {
    if (this.form.valid) {
      const formValue = { ...this.form.value };
      for (const field of this.data.fields) {
        if (field.type === 'checkboxes') {
          const checkboxGroup = formValue[field.name];
          formValue[field.name] = Object.keys(checkboxGroup).filter(key => checkboxGroup[key]);
        }
      }
  
      console.log('Datos enviados:', formValue);
  
      this.data.serviceMethod(formValue).subscribe({
        next: (response) => {
          console.log('Operación exitosa:', response);
          this.dialogRef.close(response);
        },
        error: (error) => {
          console.error('Error en la operación:', error);
        }
      });
    }
  }
  
  
}
