import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  private apiUrl = `${environment.apiUrl}/api/companies`;

  constructor(private http: HttpClient) {}

  getUserCompany(): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any>(`${this.apiUrl}/user`, { headers });
  }

  createCompany(companyData: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(this.apiUrl, companyData, { headers });
  }

  addDeviceToCompany(deviceData: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(`${this.apiUrl}/${deviceData.companyId}/devices`, deviceData, { headers });
  }
  getAllCompanies(pageNumber: number, pageSize: number): Observable<{ items: any[]; totalCount: number }> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const params = { page: pageNumber.toString(), size: pageSize.toString() };
  
    return this.http.get<{ items: any[]; totalCount: number }>(`${this.apiUrl}`, { headers, params });
  }
}
