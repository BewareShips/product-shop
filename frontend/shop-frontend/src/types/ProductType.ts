import { CategoryType } from "./CategoryType";

export enum UnitTypeEnum {
  Piece = 'Piece',
  Kilogram = 'Kilogram',
}

export interface ProductType {
   id: number;
   name: string;
   description: string;
   price: number;
   stockQuantity: number;
   categoryId: number;
   unitType: UnitTypeEnum;
  //  category?: Category;
 }