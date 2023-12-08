import { OrderItemType } from "./OrderItem";
import { OrderStatusType } from "./OrderStatusType";
import { PersonType } from "./PersonType";

export interface OrderType {
   id: number;
   personId: number;
   person: PersonType;
   orderStatusId: number;
   status: OrderStatusType;
   totalAmount: number;
   orderItems: OrderItemType[];
 }