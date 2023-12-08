import { ProductType } from "./ProductType";

export interface CategoryType {
   id: number;
   name: string;
   products?: ProductType[];
 }