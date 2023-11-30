import React from 'react'
import Product from './pages/product/Product';
import Category from './pages/category/Category';
import Cart from './pages/cart/Cart';
import Checkout from './pages/checkout/Checkout';
import Login from './pages/auth/Login';
import Register from './pages/auth/Register';
import Profile from './pages/auth/Profile';
import { Route, BrowserRouter, Routes } from 'react-router-dom';
import NotFound from './pages/notfound/NotFound';
import Home from './pages/home/Home';

interface RouteType{
  path:string;
  element:React.ReactNode;
  key:string;
}

const routes: RouteType[] = [
  { path: '/', element: <Home/>, key: 'home' },
  { path: '/product/:id', element: <Product />, key: 'product' },
  { path: '/category/:id', element: <Category />, key: 'category' },
  { path: '/cart', element: <Cart />, key: 'cart' },
  { path: '/checkout', element: <Checkout />, key: 'checkout' },
  { path: '/login', element: <Login />, key: 'login' },
  { path: '/register', element: <Register />, key: 'register' },
  { path: '/profile', element: <Profile />, key: 'profile' },
  { path: '*', element: <NotFound/>, key: 'notfound' },
]

const AppRouter:React.FC = () => {
  return (
    <BrowserRouter>
      <Routes>
        {routes.map((route)=>(
           <Route key={route.key} path={route.path} element={route.element} />
        ))}
      </Routes>
    </BrowserRouter>
  )
}

export default AppRouter