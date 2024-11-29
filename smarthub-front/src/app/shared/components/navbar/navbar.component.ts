import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatDividerModule } from '@angular/material/divider';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatDialog } from '@angular/material/dialog';
import { NotificationDetailsModalComponent } from './notification-details-modal.component';
import { AuthService } from '../../../core/services/auth.service';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { NotificationService } from '../../../core/services/notification.service';

@Component({
  standalone: true,
  selector: 'app-nav',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
  imports: [
    CommonModule,
    RouterModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatMenuModule,
    MatSlideToggleModule,
    MatDividerModule
  ]
})
export class NavComponent implements OnInit {
  isAuthenticated$: Observable<boolean>;
  notifications: any[] = [];
  filteredNotifications: any[] = [];
  showUnreadOnly = false;
  private user: any;

  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private notificationService: NotificationService
  ) {
    this.isAuthenticated$ = this.authService.isAuthenticated$;
    this.user = JSON.parse(localStorage.getItem('currentUser') || '{}');
  }

  ngOnInit(): void {
    this.loadNotifications();
  }

  logout() {
    this.authService.logout();
  }

  toggleReadFilter(showUnread: boolean) {
    this.showUnreadOnly = showUnread;
    this.filterNotifications();
  }

  private loadNotifications() {
    this.notificationService.getNotifications(this.user.userId).subscribe({
      next: (data) => {
        this.notifications = data.map((notification) => ({
          text: notification.event,
          read: notification.seen,
          photos: []
        }));
        this.filterNotifications();
      },
      error: (err) => console.error('Error al cargar notificaciones:', err)
    });
  }

  private filterNotifications() {
    this.filteredNotifications = this.showUnreadOnly
      ? this.notifications.filter(notification => !notification.seen)
      : this.notifications.filter(notification => notification.seen);
  }

  openNotificationDetails(notification: any): void {
    const dialogRef = this.dialog.open(NotificationDetailsModalComponent, {
      width: '500px',
      data: notification
    });

    dialogRef.afterClosed().subscribe((updatedNotification) => {
      if (updatedNotification && updatedNotification.seen) {
        const index = this.notifications.findIndex(n => n.id === updatedNotification.id);
        if (index !== -1) {
          this.notifications[index].seen = true;
          this.filterNotifications();
        }
      }
    });
  }
  onMenuClosed() {
    console.log('Menu closed');
  }
}
