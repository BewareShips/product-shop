import { OrderType } from './OrderType';

export enum UserRole {
   Customer = 'Customer',
   Admin = 'Admin'
}

export interface PersonType {
   id: number;
   firstName: string;
   lastName: string;
   email: string;
   password: string;
   phoneNumber?: string;
   address: string;
   role: UserRole;
   orders?: OrderType[];
}
