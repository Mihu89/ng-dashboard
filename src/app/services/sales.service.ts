import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../shared/models/order.model';

@Injectable({
  providedIn: 'root'
})
export class SalesService {

  api= 'http://localhost:5000/api/order';
  constructor(private http: HttpClient) { }

  getOrders(pageIndex: number, pageSize: number){ // :Observable<Order[]>
    return this.http.get(`${this.api}/${pageIndex}/${pageSize}`);
  }
}
