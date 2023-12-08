import { PayloadAction } from '@reduxjs/toolkit';
import { createSlice } from '@reduxjs/toolkit';
import { Category } from '../../types/CategoryType';
import { Product } from '../../types/ProductType';
import { fetchProducts } from '../../api/thunks';


interface ProductCategoryState {
   products: Product[];
   categories: Category[];
   status: 'idle' | 'loading' | 'succeeded' | 'failed';
}

const initialState: ProductCategoryState = {
   products: [],
   categories: [
      { id: 1, name: 'Biscuits' },
      { id: 2, name: 'Cakes' },
      { id: 3, name: 'Vegetables' },
      { id: 4, name: 'Fruits' },
      { id: 5, name: 'Dairy' },
      { id: 6, name: 'Beverages' },
      { id: 7, name: 'Snacks' },
      { id: 8, name: 'Bakery' },
      { id: 9, name: 'Meat' },
      { id: 10, name: 'Seafood' }
   ],
   status: 'idle'
};

const productCategoriesSlice = createSlice({
   name: 'productCategory',
   initialState,
   reducers: {
      setCategories: (state, action: PayloadAction<Category[]>) => {
         state.categories = action.payload;
      },
      addCategory: (state, action: PayloadAction<Category>) => {
         state.categories.push(action.payload);
      },
      addProduct: (state, action: PayloadAction<Product>) => {
         state.products.push(action.payload);
      },

   },
   extraReducers: (builder) => {
      builder
         .addCase(fetchProducts.pending, (state) => {
            state.status = 'loading';
         })
         .addCase(fetchProducts.fulfilled, (state, action) => {
            state.products = action.payload;
            state.status = 'succeeded';
         })
         .addCase(fetchProducts.rejected, (state) => {
            state.status = 'failed';
         });
   }
});

export const {setCategories,addCategory,addProduct} = productCategoriesSlice.actions;
export default productCategoriesSlice.reducer;