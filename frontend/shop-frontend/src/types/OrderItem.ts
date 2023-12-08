import { OrderType } from './OrderType';
import { ProductType } from './ProductType';

export interface OrderItemType {
   id: number;
   orderId: number;
   order: OrderType;
   productId: number;
   product: ProductType;
   quantity: number;
   unitPrice: number;
}
