import { PayloadAction, createSlice } from '@reduxjs/toolkit';
import { Person } from '../../types/PersonType';

interface AuthUserState {
   user: string | null;
   isAuthenticated: boolean;
   profile: Person | null;
}

const initialState: AuthUserState = {
   user: null,
   isAuthenticated: false,
   profile: null
};

const authUserSlice = createSlice({
   name: 'authUser',
   initialState,
   reducers: {
      login: (
         state,
         action: PayloadAction<{ user: string; profile: Person }>
      ) => {
         state.user = action.payload.user;
         state.isAuthenticated = true;
         state.profile = action.payload.profile;
      },
      logout: (state) => {
         state.user = null;
         state.isAuthenticated = false;
         state.profile = null;
      }
   }
});

export const {login, logout} = authUserSlice.actions;
export default authUserSlice.reducer;