import { Component, OnInit } from '@angular/core';
import { Order } from '../../shared/models/order.model';

@Component({
  selector: 'app-section-orders',
  templateUrl: './section-orders.component.html',
  styleUrls: ['./section-orders.component.css'],
})
export class SectionOrdersComponent implements OnInit {
  constructor() {}

  orders: Order[] = [
    {
      id: 1,
      customer: {
        id: 1,
        name: 'John Skeet',
        state: 'CO',
        email: 'johnS22@mail.com',
      },
      total: 250,
      ordered: new Date(2019, 12, 25),
      closed: new Date(2020, 1, 15),
      state: 'Procesed',
    },
    {
      id: 2,
      customer: {
        id: 2,
        name: 'Any Loran',
        state: 'CO',
        email: 'Loran@mail.co',
      },
      total: 380,
      ordered: new Date(2020, 2, 25),
      closed: new Date(2020, 3, 15),
      state: 'Procesed',
    },
    {
      id: 3,
      customer: {
        id: 3,
        name: 'John Rambo',
        state: 'CO',
        email: 'rambo7@mail.com',
      },
      total: 170,
      ordered: new Date(2020, 10, 20),
      closed: null,
      state: 'InProgress',
    },
  ];
  ngOnInit(): void {}
}
