import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  post(): Observable<any> {
    const body = {
      value: 'sample'
    }
    return this.http.post<any>('http://localhost:54132/api/Values/Post', body);


  }


}
