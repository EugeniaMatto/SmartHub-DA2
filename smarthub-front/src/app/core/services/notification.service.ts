import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  public apiUrl = environment.apiUrl;
  
  constructor(private http: HttpClient) {}

  getNotifications(userId: string): Observable<any[]> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any[]>(`${this.apiUrl}/api/notifications?user_id=${userId}`, { headers });
  }  
}
