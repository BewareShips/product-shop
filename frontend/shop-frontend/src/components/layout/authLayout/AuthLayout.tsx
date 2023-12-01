import React from 'react';
import styles from './AuthLayout.module.css';

interface AuthLayoutProps {
  children: React.ReactNode;
}

const AuthLayout: React.FC<AuthLayoutProps> = ({children}) => {
  return (
    <div className={`${styles.baseLayout}`}>
      <main className={`${styles.mainContent}`}>{children}</main>
    </div>
  );
};

export default AuthLayout;