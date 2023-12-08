import { configureStore } from '@reduxjs/toolkit';
import authUserSlice from './slices/authUserSlice';
import cartOrderSlice from './slices/cartOrderSlice';
import productCategorySlice from './slices/productCategorySlice';

const store = configureStore({
   reducer: {
      authUser: authUserSlice,
      cartOrder: cartOrderSlice,
      productCategory: productCategorySlice
   }
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export default store;
