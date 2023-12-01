import React from 'react'
import styles from './Header.module.css';
import { Link } from 'react-router-dom';

const navItems = [
  { path: '/', label: 'Home' },
  { path: '/product/:id', label: 'Product' },
  { path: '/category/:id', label: 'Category' },
  { path: '/cart', label: 'Cart' },
  { path: '/checkout', label: 'Checkout' },
  { path: '/profile', label: 'Profile' },
  { path: '/login', label: 'Login' },
  { path: '/register', label: 'Register' },
];

const Header:React.FC = () => {
  return (
    <header className={`${styles.header}`}>
      <nav className={`${styles.nav}`}>
        <ul className={`${styles.navList}`}>
          {navItems.map((item)=>(
            <li key={item.path} className={`${styles.navItem}`}>
              <Link to={item.path} className={`${styles.navLink}`}>
                {item.label}
              </Link>
            </li>
          ))}
        </ul>
      </nav>
    </header>
  )
}

export default Header