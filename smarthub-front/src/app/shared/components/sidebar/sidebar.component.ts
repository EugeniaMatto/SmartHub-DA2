import { Component } from '@angular/core'; 
import { RouterModule } from '@angular/router';
import { MatListModule } from '@angular/material/list';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
  imports: [
    RouterModule, 
    MatListModule,
    MatToolbarModule,
    MatIconModule,
    CommonModule
  ]
})
export class SidebarComponent {
  userRoles: string[] = [];

  constructor() {
    const user = JSON.parse(localStorage.getItem('currentUser') || '{}');
    this.userRoles = user.roles || [];
  }

  hasRole(roles: string[]): boolean {
    return roles.some(role => this.userRoles.includes(role));
  }
}
