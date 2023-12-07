import axiosInstance from './axios';

export const login = async (email: string, password: string) => {
   try {
      const responce = await axiosInstance.post('/api/Account/login', {
         email,
         password
      });
      return responce.data;
   } catch (error) {
      throw error;
   }
};

export const register = async(userData:{[key:string]:any}) =>{
   try {
      const response = await axiosInstance.post('/api/Account/register',userData);
      return response.data;
   } catch (error) {
      throw error;
   }
}