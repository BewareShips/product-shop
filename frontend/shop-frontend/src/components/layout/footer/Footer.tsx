import React from 'react';
import styles from './Footer.module.css';

const Footer: React.FC = () => {
  return (
    <div className={`${styles.footer}`}>
      <div className={`${styles.content}`}>
        <p>&copy; {new Date().getFullYear()} Shop. All rights reserved.</p>
      </div>
    </div>
  );
};

export default Footer;