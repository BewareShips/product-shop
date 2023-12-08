import { PayloadAction, createSlice } from '@reduxjs/toolkit';
import { OrderItem } from '../../types/OrderItem';
import { Order } from '../../types/OrderType';

import { submitOrder } from '../../api/thunks';

type Status = 'idle' | 'loading' | 'succeeded' | 'failed';

interface CartOrderState {
   items: OrderItem[];
   orders: Order[];
   status: Status;
   error?: string;
}

const initialState: CartOrderState = {
   items: [],
   orders: [],
   status: 'idle'
};

const cartSlice = createSlice({
   name: 'cart',
   initialState,
   reducers: {
      addItem: (state, action: PayloadAction<OrderItem>) => {
         state.items.push(action.payload);
      },
      removeItem: (state, action: PayloadAction<{ id: number }>) => {
         state.items = state.items.filter(
            (item) => item.id !== action.payload.id
         );
      },
      updateItem: (
         state,
         action: PayloadAction<{ id: Number; quantity: number }>
      ) => {
         const item = state.items.find((item) => item.id === action.payload.id);
         if (item) {
            item.quantity = action.payload.quantity;
         }
      },
      clearCart: (state) => {
         state.items = [];
      },
      addOrder: (state, action: PayloadAction<Order>) => {
         state.orders.push(action.payload);
      }
   },
   extraReducers: (builder) => {
      builder
        .addCase(submitOrder.pending, (state) => {
          state.status = 'loading';
        })
        .addCase(submitOrder.fulfilled, (state, action) => {
          state.orders.push(action.payload);
          state.items = [];
          state.status = 'succeeded';
        })
        .addCase(submitOrder.rejected, (state) => {
          state.status = 'failed';
        });
    },
});

export const { addItem, removeItem, updateItem } = cartSlice.actions;
export default cartSlice.reducer;
