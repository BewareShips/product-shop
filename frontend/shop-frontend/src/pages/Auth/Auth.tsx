import React, { useState } from 'react';
import styles from './Auth.module.css';
import Login from '../../components/login/Login';
import Register from '../../components/register/Register';
import Button from '../../components/common/button/Button';

const Auth: React.FC = () => {
  const [isLogin, setIsLogin] = useState(true);

  const toggleAuthMode = () => {
    setIsLogin(!isLogin);
  };

  return (
    <div className={styles.authContainer}>
      <div className={`${styles.authBox} ${isLogin ? styles.loginMode : styles.registerMode}`}>
        <div className={`${styles.formContainer} ${isLogin ? styles.formContainerLogin : ''}`}>
          {isLogin ? <Login /> : <Register />}
        </div>
        <div className={styles.overlayContainer}>
          <div className={styles.overlayPanel}>
            {isLogin ? (
              <>
                <h2>Hello, Friend!</h2>
                <p>Register with your personal details to use all of site features</p>
                <Button type="button" onClick={toggleAuthMode} className={styles.ghost} id="signUp">
                  Register
                </Button>
              </>
            ) : (
              <>
                <h2>Welcome Back!</h2>
                <p>If you already have an account, sign in here</p>
                <Button type="button" onClick={toggleAuthMode} className={styles.ghost } id="signIn">
                  Log in
                </Button>
              </>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default Auth;
