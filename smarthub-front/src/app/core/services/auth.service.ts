import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../constants/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = environment.apiUrl;
  private currentUserSubject: BehaviorSubject<any>;
  public currentUser: Observable<any>;

  private isAuthenticatedSubject: BehaviorSubject<boolean>;
  public isAuthenticated$: Observable<boolean>;

  constructor(private http: HttpClient, private router: Router) {
    const token = this.getLocalStorageItem('authToken');
    this.isAuthenticatedSubject = new BehaviorSubject<boolean>(!!token);
    this.isAuthenticated$ = this.isAuthenticatedSubject.asObservable();
    
    const storedUser = this.getLocalStorageItem('currentUser');
    this.currentUserSubject = new BehaviorSubject<any>(storedUser ? JSON.parse(storedUser) : null);
    this.currentUser = this.currentUserSubject.asObservable();
  }

  login(email: string, password: string) {
    return this.http.post<{ 
        token: string, 
        name: string, 
        surname: string, 
        email: string, 
        profilePhoto: string, 
        roles: string[], 
        createdAt: string ,
        userId: string
      }>(`${this.apiUrl}/api/user/login`, { email, password })
      .pipe(
        map((response: { 
          token: string, 
          name: string, 
          surname: string, 
          email: string, 
          profilePhoto: string, 
          roles: string[], 
          createdAt: string,
          userId: string
        }) => {
          if (response.token) {
            this.setLocalStorageItem('authToken', response.token);
            const userInfo = {
              name: response.name,
              surname: response.surname,
              email: response.email,
              profilePhoto: response.profilePhoto,
              roles: response.roles,
              userId: response.userId
            };
            this.setLocalStorageItem('currentUser', JSON.stringify(userInfo));
            this.isAuthenticatedSubject.next(true);
          }
          return response;
        })
      );
  }  
  
  register(
    name: string, 
    surname: string, 
    email: string, 
    password: string, 
    profilePhoto: string
  ) {
    const registerPayload = {
      Name: name,
      Surname: surname,
      Email: email,
      Password: password,
      ProfilePhoto: profilePhoto
    };
  
    return this.http.post<{ 
      token: string, 
      name: string, 
      surname: string, 
      email: string, 
      profilePhoto: string, 
      roles: string[], 
      createdAt: string,
      userId: string
    }>(`${this.apiUrl}/api/home-owners`, registerPayload)
      .pipe(
        map((response) => {
          if (response.token) {
            this.setLocalStorageItem('authToken', response.token);
            const userInfo = {
              name: response.name,
              surname: response.surname,
              email: response.email,
              profilePhoto: response.profilePhoto,
              roles: response.roles,
              userId: response.userId
            };
            this.setLocalStorageItem('currentUser', JSON.stringify(userInfo));
            this.isAuthenticatedSubject.next(true);
            this.currentUserSubject.next(userInfo);
          }
          return response;
        })
      );
  }
  
  

  logout() {
    this.removeLocalStorageItem('authToken');
    this.removeLocalStorageItem('currentUser');
    
    this.isAuthenticatedSubject.next(false);
    this.currentUserSubject.next(null);
  
    this.router.navigate(['/login']);
  }
  

  public get isAuth(): boolean {
    return this.isAuthenticatedSubject.value;
  }

  public getToken(): string | null {
    return this.getLocalStorageItem('authToken');
  }

  private getLocalStorageItem(key: string): string | null {
    if (typeof window !== 'undefined' && window.localStorage) {
      return localStorage.getItem(key);
    }
    return null;
  }

  private setLocalStorageItem(key: string, value: string): void {
    if (typeof window !== 'undefined' && window.localStorage) {
      localStorage.setItem(key, value);
    }
  }

  private removeLocalStorageItem(key: string): void {
    if (typeof window !== 'undefined' && window.localStorage) {
      localStorage.removeItem(key);
    }
  }
}
