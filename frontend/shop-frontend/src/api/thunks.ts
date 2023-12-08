import { createAsyncThunk } from "@reduxjs/toolkit";
import axiosInstance from "./axios";

export const submitOrder  = createAsyncThunk(
   'productCategory/fetchProducts',
   async () => {
      const response = await axiosInstance.get('/api/Product/AllProducts');
      return response.data;
   }
);

export const fetchProducts = createAsyncThunk(
   'productCategory/fetchProducts',
   async () => {
      const response = await axiosInstance.get('/api/Product/AllProducts');
      return response.data;
   }
);