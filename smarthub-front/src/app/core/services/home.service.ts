import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class HomesService {
  public apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getHomes(): Observable<any[]> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any[]>(`${this.apiUrl}/api/user/homes`, { headers });
  }

  getHomeById(homeId: string): Observable<any> {
    return this.getHomes().pipe(
      map(homes => homes.find(home => home.homeId === homeId))
    );
  }

  addHome(homeData: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(`${this.apiUrl}/api/homes`, homeData, { headers });
  }

  addRoom(roomData: any, homeId: string): Observable<any> {
    const payload = { Rooms: [roomData.Room] };
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.patch<any>(`${this.apiUrl}/api/homes/${homeId}/rooms`, payload, { headers });
  }

  getRoomsByHomeId(homeId: string): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any>(`${this.apiUrl}/api/homes/${homeId}/rooms`, { headers });
  }

  getDevicesByHomeId(homeId: string): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any>(`${this.apiUrl}/api/homes/${homeId}/devices`, { headers });
  }

  getHomeMembers(homeId: string): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const params = new HttpParams().set('homeId', homeId);
    return this.http.get<any>(`${this.apiUrl}/api/members`, { headers, params });
  }

  getHomePermissions(): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.get<any>(`${this.apiUrl}/api/homes/permissions`, { headers });
  }

  addHomeMember(memberData: any, homeId: string): Observable<any> {
    console.log('memberData', memberData);
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const params = new HttpParams().set('homeId', homeId);
    return this.http.post<any>(`${this.apiUrl}/api/members`, memberData, { headers, params });
  }

  addDeviceToRoom(homeId: string, payload: any): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    return this.http.post<any>(`${this.apiUrl}/api/homes/${homeId}/devices`, payload, { headers });
  }

  updateMemberPermissions(memberId: string, body: { Permissions: string[], HomeId: string }): Observable<any> {
    console.log({ memberId, body });
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/members/${memberId}/permissions`;
    return this.http.put(url, body, { headers });
  }

  turnDeviceOn(homeId: string, hardwareId: string): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/homes/devices/on`;
    const payload = {
      HomeId: homeId,
      HardwareId: hardwareId
    };
    return this.http.patch<any>(url, payload, { headers });
  }

  turnDeviceOff(homeId: string, hardwareId: string): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/homes/devices/off`;
    const payload = {
      HomeId: homeId,
      HardwareId: hardwareId
    };
    return this.http.patch<any>(url, payload, { headers });
  }

  changeDeviceRoom(homeId: string, payload: { Room: string; HardwareId: string }): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/homes/${homeId}/devices/room`;
    return this.http.patch<any>(url, payload, { headers });
  }


  addNotificationPermissions(homeId: string, emails: string[]): Observable<any> {
    const headers = new HttpHeaders().set('Authorization', `${localStorage.getItem('authToken')}`);
    const url = `${this.apiUrl}/api/members/${homeId}/notification`;
    return this.http.patch(url, emails, {headers});
  }
  
}
