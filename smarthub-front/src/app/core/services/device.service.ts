import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../constants/environment';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class DeviceService {
  private apiUrl = `${environment.apiUrl}/api/devices`;

  constructor(private http: HttpClient, private authService: AuthService) {}

  getDevices(): Observable<any> {
    const token = this.authService.getToken(); 
    const headers = new HttpHeaders({
      'Authorization': `${token}`
    });

    return this.http.get(this.apiUrl, { headers });
  }

  getDeviceTypes(): Observable<string[]> {
    const token = this.authService.getToken(); 
    const headers = new HttpHeaders({
      'Authorization': `${token}`
    });

    const url = `${environment.apiUrl}/api/device-types`;
    return this.http.get<string[]>(url, { headers });
  }
  getImporters(): Observable<string[]> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<string[]>(`${this.apiUrl}/import`, { headers });
  }

  addDevicesLot(lot: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post(`${this.apiUrl}/import`, lot, { headers });
  }

  addDevice(type: string, body: any): Observable<any> {
    const url = `${environment.apiUrl}/api/${type}`;
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      'Authorization': `${token}`,
      'Content-Type': 'application/json',
    });
  
    return this.http.post(url, body, { headers });
  }

  sendDeviceData(type: string, body: any): Observable<any> {
    const url = `${environment.apiUrl}/api/${type}`;
    const token = this.authService.getToken();
    const headers = new HttpHeaders({
      'Authorization': `${token}`,
      'Content-Type': 'application/json',
    });
  
    return this.http.post(url, body, { headers });
  }
  
  
}
