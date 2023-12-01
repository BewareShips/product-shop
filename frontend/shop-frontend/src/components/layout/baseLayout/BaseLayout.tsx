import React from 'react';
import styles from './BaseLayout.module.css';
import Header from '../header/Header';
import Footer from '../footer/Footer';

interface BaseLayoutProps {
  children: React.ReactNode;
}

const BaseLayout: React.FC<BaseLayoutProps> = ({ children }) => {
  return (
    <div className={`${styles.baseLayout}`}>
      <Header/>
      <main className={`${styles.mainContent}`}>{children}</main>
      <Footer/>
    </div>
  );
};

export default BaseLayout;