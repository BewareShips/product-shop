import { OrderType } from './OrderType';

export interface OrderStatusType {
   id: number;
   statusName: string;
   orders?: OrderType[];
}
