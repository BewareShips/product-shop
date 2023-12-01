import React from 'react';
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
import AuthLayout from './components/layout/authLayout/AuthLayout';
import BaseLayout from './components/layout/baseLayout/BaseLayout';

interface RouteType {
  path: string;
  element: React.ReactNode;
  key: string;
  layout?: React.FC<{ children: React.ReactNode; }>;
}

const routes: RouteType[] = [
  { path: '/', element: <Home />, key: 'home', layout: BaseLayout },
  { path: '/product/:id', element: <Product />, key: 'product', layout: BaseLayout },
  { path: '/category/:id', element: <Category />, key: 'category', layout: BaseLayout },
  { path: '/cart', element: <Cart />, key: 'cart', layout: BaseLayout },
  { path: '/checkout', element: <Checkout />, key: 'checkout', layout: BaseLayout },
  { path: '/login', element: <Login />, key: 'login', layout: AuthLayout },
  { path: '/register', element: <Register />, key: 'register', layout: AuthLayout },
  { path: '/profile', element: <Profile />, key: 'profile', layout: BaseLayout },
  { path: '*', element: <NotFound />, key: 'notfound' }
];

const AppRouter: React.FC = () => {
  return (
    <BrowserRouter>
      <Routes>
        {routes.map((route) => {
          const Layout = route.layout || React.Fragment
          return (
            <Route
              key={route.key}
              path={route.path}
              element={<Layout>{route.element}</Layout>}
            />
          );
        })}
      </Routes>
    </BrowserRouter>
  );
};

export default AppRouter;