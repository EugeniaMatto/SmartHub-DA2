import { Component } from '@angular/core';
import { Validators, FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { AuthService } from '../../core/services/auth.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { NavComponent } from '../../shared/components/navbar/navbar.component'; 

@Component({
  standalone: true,
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatToolbarModule,
    MatCardModule,
    NavComponent
  ]
})
export class RegisterPage {
  registerForm: FormGroup;
  errorMessage: string | null = null;

  constructor(
    private authService: AuthService,
    private router: Router
  ) {
    this.registerForm = new FormGroup({
      name: new FormControl('', [Validators.required]),
      surname: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.minLength(6)]),
      profilePhoto: new FormControl('', [Validators.required])
    });
  }

  onSubmit() {
    if (this.registerForm.valid) {
      const { name, surname, email, password, profilePhoto } = this.registerForm.value;

      this.authService.register(name, surname, email, password, profilePhoto).subscribe({
        next: () => {
          console.log('Registration successful');
          this.router.navigate(['/dashboard']);
        },
        error: (err: any) => {
          if (err.error.innerCode === 'ValidationError') {
            this.errorMessage = err.error.message;
          } else {
            this.errorMessage = 'No se pudo registrar el usuario. Por favor, intenta de nuevo.';
          }
        }
      });
    } else {
      console.log('Formulario inválido');
    }
  }
}
