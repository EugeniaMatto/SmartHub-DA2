import { Routes } from '@angular/router';
import { DashboardPage } from './pages/dashboard/dashboard.component';
import { LoginPage } from './pages/login/login.component';
import { RegisterPage } from './pages/register/register.component';
import { DevicesComponent } from './pages/devices/devices.component';
import { AuthGuard } from './core/guards/authGuard.guard';
import { NoAuthGuard } from './core/guards/no-auth.guard';
import { HomesComponent } from './pages/homes/homes.component';
import { HomeDetailComponent } from './pages/home-detail/home-detail.component';
import { CompanyComponent } from './pages/company/company.component';
import { RoleGuard } from './core/guards/role.guard';

export const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { 
    path: 'dashboard', 
    component: DashboardPage, 
    canActivate: [AuthGuard], 
    children: [
      { 
        path: 'devices', 
        component: DevicesComponent 
      },
      { 
        path: 'homes', 
        component: HomesComponent, 
        canActivate: [RoleGuard], 
        data: { roles: ['HomeOwner'] } 
      },
      { 
        path: 'homes/:homeId', 
        component: HomeDetailComponent, 
        canActivate: [RoleGuard], 
        data: { roles: ['HomeOwner'] } 
      },
      { 
        path: 'company', 
        component: CompanyComponent, 
        canActivate: [RoleGuard], 
        data: { roles: ['CompanyOwner'] } 
      }
    ]
  },
  { path: 'login', component: LoginPage, canActivate: [NoAuthGuard] },
  { path: 'register', component: RegisterPage, canActivate: [NoAuthGuard] },
  { path: '**', redirectTo: '/dashboard', pathMatch: 'full' }
];
