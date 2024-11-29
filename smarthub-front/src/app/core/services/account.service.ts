import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
    private apiUrlAccounts = `${environment.apiUrl}/api/accounts`;
    private apiUrlAdministrators = `${environment.apiUrl}/api/administrators`;
    private apiUrlHomeOwners = `${environment.apiUrl}/api/home-owners/permissions`;
    private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getAllAccounts(pageNumber: number = 1, pageSize: number = 10): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/accounts?pageNumber=${pageNumber}&pageSize=${pageSize}`;
    return this.http.get<any>(url, { headers });
  }

  getAllAccountsEmails(): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/home-owners/emails`;
    return this.http.get<any>(url, { headers });
  }
   

  getAdministrators(pageNumber: number = 0, pageSize: number = 10): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrlAccounts}?role=Administrator&pageNumber=${pageNumber}&pageSize=${pageSize}`;
    return this.http.get<any>(url, { headers });
  }

  createAdminAccount(adminData: { Name: string; Surname: string; Email: string; Password: string }): Observable<any> {
    const headers = new HttpHeaders({
      'Authorization': `${localStorage.getItem('authToken')}`,
      'Content-Type': 'application/json'
    });

    return this.http.post<any>(this.apiUrlAdministrators, adminData, { headers });
  }

  deleteAdminAccount(accountId: string): Observable<any> {
    const headers = new HttpHeaders({
      'Authorization': `${localStorage.getItem('authToken')}`
    });
    const url = `${this.apiUrlAdministrators}/${accountId}`;
    return this.http.delete<any>(url, { headers });
  }
  

  addCompanyOwner(companyOwnerData: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(`${this.apiUrl}/api/company-owners`, companyOwnerData, { headers });
  }
  
  addHomeOwnerPermission(): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(this.apiUrlHomeOwners, {}, { headers });
}
}
