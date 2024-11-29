import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { Validators } from '@angular/forms';
import { SidebarComponent } from '../../shared/components/sidebar/sidebar.component';
import { NavComponent } from '../../shared/components/navbar/navbar.component';
import { AddAdminFormComponent } from './add-admin-user-dialog.component';
import { MatExpansionModule } from '@angular/material/expansion';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../../core/services/account.service';
import { HomesService } from '../../core/services/home.service';
import { CompanyService } from '../../core/services/company.service';
import { DataTableComponent } from '../../shared/components/data-table/data-table.component';

interface TableColumn {
  columnDef: string;
  header: string;
  cell: (element: any) => string;
}
interface AdminData {
  Name: string;
  Surname: string;
  Email: string;
  Password: string;
}

@Component({
  standalone: true,
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
  imports: [
    CommonModule,
    MatSidenavModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    RouterModule,
    SidebarComponent,
    NavComponent,
    MatExpansionModule,
    DataTableComponent,
    MatPaginatorModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    FormsModule,
  ]
})
export class DashboardPage implements OnInit {
  isDashboardRoute: boolean = false;
  user: any = JSON.parse(localStorage.getItem('currentUser') || '{}');
  allAccounts: any[] = [];
  allCompanies: any[] = [];
  allAccountsEmails: string[] = [];
  filteredAccounts: any[] = [];
  admins: any[] = [];
  homeMembers: any[] = [];
  companyMembers: any[] = [];
  company: any = null;
  homePermissions: any[] = [];

  totalAccounts: number = 0;
  pageSize: number = 10;
  pageIndex: number = 1;
  searchTerm: string = '';
  selectedRole: string = '';
  availableRoles: string[] = ['Administrator', 'HomeOwner', 'CompanyOwner'];
  companyTotal: number = 0;
  companyPageSize: number = 10;
  companyPageIndex: number = 1;

  isAdmin = (account: any): boolean => account.isAdmin;

  
  adminColumns: TableColumn[] = [
    { columnDef: 'name', header: 'Nombre', cell: (element: any) => element.name },
    { columnDef: 'surname', header: 'Apellido', cell: (element: any) => element.surname },
    { columnDef: 'roles', header: 'Roles', cell: (element: any) => element.roles.join(', ') },
  ];

  homeMemberColumns: TableColumn[] = [
    { columnDef: 'name', header: 'Nombre', cell: (element: any) => element.name },
    { columnDef: 'surname', header: 'Apellido', cell: (element: any) => element.surname },
    { columnDef: 'permissions', header: 'Permisos', cell: (element: any) => element.permissions.join(', ')  },
    { columnDef: 'homeName', header: 'Hogar', cell: (element: any) => element.homeName },
  ];

  companyMemberColumns: TableColumn[] = [
    { columnDef: 'name', header: 'Nombre', cell: (element: any) => element.name },
    { columnDef: 'position', header: 'Posición', cell: (element: any) => element.position },
    { columnDef: 'department', header: 'Departamento', cell: (element: any) => element.department },
  ];

  CompaniesColumns: TableColumn[] = [
    { columnDef: 'name', header: 'Nombre', cell: (element: any) => element.name },
    { columnDef: 'rut', header: 'RUT', cell: (element: any) => element.rut },
    { columnDef: 'ownerId', header: 'Dueño', cell: (element: any) => element.ownerId },
  ];

  constructor(private router: Router, private dialog: MatDialog, private accountService: AccountService, private homeService: HomesService, private CompanyService: CompanyService) {}

  ngOnInit() {
    this.isDashboardRoute = this.router.url === '/dashboard';
    this.router.events
      .pipe(filter(event => event instanceof NavigationEnd))
      .subscribe((event: NavigationEnd) => {
        this.isDashboardRoute = event.urlAfterRedirects === '/dashboard';
      });
      if (this.user.roles.includes('Administrator')) {
        this.loadAllAccounts(this.pageIndex, this.pageSize);
        this.loadAllCompanies(this.companyPageIndex, this.companyPageSize);
      }
    if (this.user.roles.includes('HomeOwner')) {
      this.loadHomeMembers();
      this.loadAllAccountsEmails();
      this.loadHomePermissions();
    }
    if (this.user.roles.includes('CompanyOwner')) {
      this.loadCompany();
    }
  }

  loadAllCompanies(pageNumber: number = 1, pageSize: number = 10): void {
    this.CompanyService.getAllCompanies(pageNumber, pageSize).subscribe({
      next: (response) => {
        this.allCompanies = response.items;
        this.companyTotal = response.totalCount;
      },
      error: (error) => {
        console.error('Error al cargar las compañías', error);
        this.allCompanies = [];
      }
    });
  }

  onCompanyPageChange(event: PageEvent): void {
    this.companyPageIndex = event.pageIndex + 1;
    this.companyPageSize = event.pageSize;
    this.loadAllCompanies(this.companyPageIndex, this.companyPageSize);
  }

  loadCompany(): void {
    this.CompanyService.getUserCompany().subscribe({
      next: (data) => {
        this.company = data;
      },
      error: (error) => {
        console.error('Error al cargar la compañía', error);
        this.company = null;
      }
    });
  }

  loadAllAccounts(pageNumber: number = 1, pageSize: number = 10): void {
    this.accountService.getAllAccounts(pageNumber, pageSize).subscribe(response => {
      this.allAccounts = response.items.map((account: any) => ({
        ...account,
        isAdmin: account.roles.includes('Administrator')
      }));
      this.filteredAccounts = [...this.allAccounts];
      this.totalAccounts = response.totalCount;
      this.applyFilters();
    });
  }
  loadHomePermissions(): void {
    this.homeService.getHomePermissions().subscribe(permissions => {
      this.homePermissions = permissions;
    });
  }

  loadAllAccountsEmails(): void {
    this.accountService.getAllAccountsEmails().subscribe({
      next: (data) => {
        this.allAccountsEmails = data;
      },
      error: (error) => {
        console.error('Error al cargar los emails de las cuentas', error);
        this.allAccountsEmails = [];
      }
    });
  }

  applyFilters(): void {
    this.filteredAccounts = this.allAccounts.filter(account => {
      const matchesSearchTerm =
        this.searchTerm === '' ||
        account.name.toLowerCase().includes(this.searchTerm.toLowerCase()) ||
        account.surname.toLowerCase().includes(this.searchTerm.toLowerCase()) ||
        account.roles.some((role: string) => role.toLowerCase().includes(this.searchTerm.toLowerCase()));

      const matchesRole = this.selectedRole === '' || account.roles.includes(this.selectedRole);

      return matchesSearchTerm && matchesRole;
    });
  }

  loadHomeMembers(): void {
    this.homeService.getHomes().subscribe(homes => {
      const homeMembersList: any[] = [];
      homes.forEach(homeObj => {
        const homeId = homeObj.home.id;
                
        if (homeId) { 
          this.homeService.getHomeMembers(homeId).subscribe(members => {
            const membersWithHomeName = members.map((member: any) => ({
              ...member,
              homeName: homeObj.home.name,
              homeId: homeObj.home.id
            }));          
            homeMembersList.push(...membersWithHomeName);
            this.homeMembers = homeMembersList;
          });
        } else {
          console.warn('El home no tiene un ID válido:', homeObj);
        }
      });
    });
  }  
  
  deleteAdmin(admin: any): void {
    const accountId = admin.id;
    const confirmation = confirm(`¿Estás seguro de que deseas eliminar al administrador ${admin.name} ${admin.surname}?`);
  
    if (confirmation) {
      this.accountService.deleteAdminAccount(accountId)
        .subscribe({
          next: () => {
            this.loadAllAccounts(this.pageIndex, this.pageSize);
          },
          error: (error) => {
            console.error('Error al eliminar el administrador:', error);
          }
        });
    }
  }
  
  openCreateAdmin(): void {
    const dialogRef = this.dialog.open(AddAdminFormComponent, {
      width: '400px',
      data: {
        title: 'Crear Nuevo Administrador',
        fields: [
          { name: 'Name', label: 'Nombre', type: 'text', validators: [Validators.required] },
          { name: 'Surname', label: 'Apellido', type: 'text', validators: [Validators.required] },
          { name: 'Email', label: 'Correo Electrónico', type: 'email', validators: [Validators.required, Validators.email] },
          { name: 'Password', label: 'Contraseña', type: 'password', validators: [Validators.required] }
        ],
        serviceMethod: (formData: AdminData) => this.accountService.createAdminAccount(formData)
      }
    });
  
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadAllAccounts(this.pageIndex, this.pageSize);
      }
    });
  }
  openCreateMemberHome(): void {
    if (this.user.roles.includes('HomeOwner')) {
      this.homeService.getHomes().subscribe(homesResponse => {
        const availableHomes = homesResponse.map(homeObj => ({
          value: homeObj.home.id,
          label: homeObj.home.name
        }));
        const permissions = this.homePermissions.map(permission => ({
          value: permission,
          label: permission
        }));
  
        const availableAccounts = this.allAccountsEmails.filter(
          email => !this.homeMembers.some(member => member.email === email)
        );
  
        const dialogRef = this.dialog.open(AddAdminFormComponent, {
          width: '400px',
          data: {
            title: 'Agregar Nuevo Miembro de Casa',
            fields: [
              {
                name: 'homeId',
                label: 'Casa',
                type: 'select',
                options: availableHomes,
                validators: [Validators.required]
              },
              {
                name: 'memberEmail',
                label: 'Email',
                type: 'select',
                options: availableAccounts.map(account => ({ value: account, label: account })),
                validators: [Validators.required]
              },
              {
                name: 'permissions',
                label: 'Permisos',
                type: 'checkboxes',
                options: permissions
              }
            ],
            serviceMethod: (formData: any) => this.homeService.addHomeMember(
              {
                memberEmail: formData.memberEmail,
                permissions: formData.permissions 
              },
              formData.homeId
            ),
            accountData: availableAccounts
          }
        });
  
        dialogRef.afterClosed().subscribe(result => {
          if (result) {
            this.loadHomeMembers();
          }
        });
      });
    }
  }  
  
  openCreateCompanyOwner(): void {
    const dialogRef = this.dialog.open(AddAdminFormComponent, {
      width: '400px',
      data: {
        title: 'Crear Dueño de Empresa',
        fields: [
          { name: 'Name', label: 'Nombre', type: 'text', validators: [Validators.required] },
          { name: 'Surname', label: 'Apellido', type: 'text', validators: [Validators.required] },
          { name: 'Email', label: 'Correo Electrónico', type: 'email', validators: [Validators.required, Validators.email] },
          { name: 'Password', label: 'Contraseña', type: 'password', validators: [Validators.required] }
        ],
        serviceMethod: (formData: any) => this.accountService.addCompanyOwner(formData)
      }
    });
  
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        console.log('Nuevo Dueño de Empresa creado exitosamente:', result);
      }
    });
  }

  onPageChange(event: PageEvent): void {
    const pageNumber = event.pageIndex + 1; 
    this.pageSize = event.pageSize;
    
    this.loadAllAccounts(pageNumber, this.pageSize);
  }
  
  openCreateHome(): void {
    const confirmation = confirm(`¿Estás seguro de que deseas añadirte los permisos de Dueño de hogar?`);
  
    if (confirmation) {
      this.accountService.addHomeOwnerPermission().subscribe({
        next: () => {
          console.log('Permisos agregados');
          if (!this.user.roles.includes('HomeOwner')) {
            this.user.roles.push('HomeOwner');
            localStorage.setItem('currentUser', JSON.stringify(this.user));
          }
          this.loadHomeMembers();
        },
        error: (error) => {
          console.error('Problemas al agregar permisos');
        }
      });
    }
  }
  openEditPermissions(member: any): void {
    const allPermissions = this.homePermissions.map(permission => ({
      value: permission,
      label: permission,
      checked: member.permissions.includes(permission)
    }));
    const dialogRef = this.dialog.open(AddAdminFormComponent, {
      width: '400px',
      data: {
        title: `Editar Permisos de ${member.name}`,
        fields: [
          {
            name: 'permissions',
            label: 'Permisos',
            type: 'checkboxes',
            options: allPermissions
          }
        ],
        serviceMethod: (formData: any) => this.homeService.updateMemberPermissions(
          member.id,
          {
            Permissions: formData.permissions,
            HomeId: member.homeId
          }
        )
      }
    });
  
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadHomeMembers();
      }
    });
  }
  
  
}
