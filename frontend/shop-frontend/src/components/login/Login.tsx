/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';
import styles from './Login.module.css';
import { useNavigate } from 'react-router-dom';
import Input from '../common/input/Input';
import useInput from '../../hooks/useInput';
import Button from '../common/button/Button';
import { login } from '../../api/auth';

const Login: React.FC = () => {
   const email = useInput('', { isEmail: true });
   const password = useInput('');
   const navigate = useNavigate();
   const handleLogin = async (e: React.FormEvent) => {
      e.preventDefault();
      try {
         const data = await login(email.value, password.value);
         localStorage.setItem('token', data.token);
         navigate('/');
         console.log('Login successful');
      } catch (error) {
         console.log('Login failed', error);
      }
   };

   return (
      <div className={`${styles.formContainer}`}>
         <h2>Log in</h2>
         <form onSubmit={handleLogin}>
            <Input
               value={email.value}
               onChange={email.onChange}
               onBlur={email.onBlur}
               placeholder="Email"
               isDirty={email.isDirty}
            />
            <Input
               value={password.value}
               onChange={password.onChange}
               onBlur={password.onBlur}
               placeholder="Password"
               isDirty={password.isDirty}
            />
            <Button type="submit">Log in</Button>
         </form>
      </div>
   );
};

export default Login;
