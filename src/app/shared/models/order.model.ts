import { Customer } from './customer.model';

export interface Order {
    id: number;
    customer: Customer;
    total: number;
    ordered: Date;
    closed: Date; 
    state: string;
}
