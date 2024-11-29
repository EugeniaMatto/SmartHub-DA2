import { Component, OnInit } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { HomesService } from '../../core/services/home.service';
import { HomeFormComponent } from './home-form.component';

@Component({
    standalone: true,
    selector: 'app-homes',
    templateUrl: './homes.component.html',
    styleUrls: ['./homes.component.scss'],
    imports: [
      CommonModule,
      MatCardModule,
      MatButtonModule
    ]
  })
export class HomesComponent implements OnInit {
  homes: any[] = [];

  constructor(private homesService: HomesService, private dialog: MatDialog,  private router: Router) {}

  ngOnInit(): void {
    this.loadHomes();
  }

  loadHomes(): void {
    this.homesService.getHomes().subscribe({
      next: (data) => {
        this.homes = data;
      },
      error: (error) => {
        console.error('Error al cargar los hogares', error);
      }
    });
  }

  openHomeForm(): void {
    const dialogRef = this.dialog.open(HomeFormComponent, {
      width: '400px',
      data: {}
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadHomes();
      }
    });
  }

  navigateToHome(homeId: string): void {
    this.router.navigate([`/dashboard/homes/${homeId}`]);
  }
}
