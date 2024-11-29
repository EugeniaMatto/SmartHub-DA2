import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { CommonModule } from '@angular/common';
import { CompanyService } from '../../core/services/company.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { CompanyFormComponent } from './company-form.component';
import { AddDeviceDialogComponent } from '../add-device-dialog/add-device-dialog.component';
import { DeviceService } from '../../core/services/device.service';

@Component({
  selector: 'app-company',
  standalone: true,
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.scss'],
  imports: [CommonModule, MatButtonModule, MatTableModule]
})
export class CompanyComponent implements OnInit {
  company: any = null;
  importers: any[] = [];
  displayedColumns: string[] = ['name', 'model', 'description', 'photos'];

  constructor(private CompanyService: CompanyService, private dialog: MatDialog, private http: HttpClient, private DeviceService: DeviceService) {}

  ngOnInit(): void {
    this.loadCompany();
    this.loadImporters();
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

  loadImporters(): void {
    this.DeviceService.getImporters().subscribe({
      next: (data) => {
        this.importers = data.map(type => ({
          description: `Importador de tipo ${type}`,
          type: type
        }));
        console.log('Importadores disponibles (transformados):', this.importers);
      },
      error: (error) => {
        console.error('Error al cargar los importadores:', error);
        this.importers = [];
      }
    });
  }
  

  openCompanyForm(): void {
    const dialogRef = this.dialog.open(CompanyFormComponent, {
      width: '600px',
      data: {}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.loadCompany();
      }
    });
  }

  openAddDeviceDialog(): void {
    const dialogRef = this.dialog.open(AddDeviceDialogComponent, {
      width: '400px',
    });
  
    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        const body: any = {
          Name: result.name,
          ModelNumber: result.modelNumber,
          Description: result.description,
          Photos: result.photos,
        };
        if (result.type === 'cameras') {
          Object.assign(body, {
            UseTypes: result.useTypes || [],
            SupportedActions: result.supportedActions || [],
          });
        }

        this.DeviceService.addDevice(result.type, body).subscribe({
          next: (response) => {
            console.log('Dispositivo agregado exitosamente', response);
            this.loadCompany();
          },
          error: (error) => {
            console.error('Error al agregar el dispositivo', error);
          },
        });
      }
    });
  }
  

  uploadDevicesWithImporter(): void {
    if (this.importers.length === 0) {
      alert('No hay importadores disponibles. Por favor, intenta más tarde.');
      return;
    }
  
    const importerSelection = window.prompt(
      `Selecciona un importador:\n` +
      this.importers.map((imp, index) => 
        `${index + 1}. ${imp.description || 'Sin descripción'} (${imp.type || 'Sin tipo'})`
      ).join('\n')
    );
  
    if (importerSelection) {
      const selectedIndex = parseInt(importerSelection) - 1;
  
      if (selectedIndex >= 0 && selectedIndex < this.importers.length) {
        const selectedImporter = this.importers[selectedIndex];
  
        if (!selectedImporter.type) {
          alert('El importador seleccionado no tiene un tipo válido.');
          return;
        }
  
        this.selectFileAndUpload(selectedImporter.type);
      } else {
        alert('Importador inválido. Por favor, inténtalo nuevamente.');
      }
    }
  }
  
  selectFileAndUpload(importerType: string): void {
    const input = document.createElement('input');
    input.type = 'file';
    input.accept = `.${importerType}`;
  
    input.onchange = (event: any) => {
      const file = event.target.files[0];
      if (file) {
        const fileName = file.name;
        this.uploadDevices(fileName, importerType);
      }
    };
  
    input.click();
  }
  
  uploadDevices(fileName: string, importerType: string): void {
    if (!fileName || !importerType) {
      alert('Faltan datos para realizar la importación. Por favor, verifica el archivo y el tipo de importador.');
      return;
    }
  
    const payload = {
      source: fileName,
      type: importerType
    };
  
    this.DeviceService.addDevicesLot(payload).subscribe({
      next: (response) => {
        console.log('Archivo importado exitosamente:', response);
        alert('Archivo importado exitosamente.');
        this.loadCompany();
      },
      error: (error) => {
        console.error('Error al importar el archivo:', error);
        alert('Error al importar el archivo. Verifica el formato o intenta nuevamente.');
      }
    });
  }
  
  
}
