import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Users } from './users'
import { Observable } from 'rxjs';
import { CompileShallowModuleMetadata } from '@angular/compiler';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { }

  private url = 'https://localhost:44348/';
  private loginurl = 'https://localhost:44348/login/'
  private registerurl = `https://localhost:44348/register/`

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  userlist(): Observable<Users[]> {

    return this.http.get<Users[]>(`${this.url}userlist`);
  }

  loginuser(u: Users): Observable<Users> {

    return this.http.get<Users>(`${this.loginurl}${u.Username}/${u.Password}`);
  }


  //Register a new user
  registeruser(u: Users): Observable<Users> {
    console.log('made it to service')
    return this.http.post<Users>(`${this.registerurl}${u.firstName}/${u.lastName}/${u.email}/${u.Username}/${u.Password}/${u.dob}`, this.httpOptions);
  }

  storeuser(u: Users) {
    sessionStorage.setItem('currentuser', (`${u.firstName} ${u.lastName}`))

  }



  getUserDetails(username: string, password: string): Observable<Users> {
    // post these details to API server return user info if correct
    return this.http.get<Users>(`${this.loginurl}${username}/${password}`, {
      //username,
      //password
    })
  }

}
