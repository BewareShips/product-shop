import React from 'react'
import Product from './pages/Product/Product';
import Category from './pages/Category/Category';
import Cart from './pages/Cart/Cart';
import Checkout from './pages/Checkout/Checkout';
import Login from './pages/Auth/Login';
import Register from './pages/Auth/Register';
import Profile from './pages/Auth/Profile';
import { Route, BrowserRouter, Routes } from 'react-router-dom';
import NotFound from './components/common/notfound/NotFound';
import Home from './pages/Home/Home';

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