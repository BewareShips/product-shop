/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from 'react';
import styles from './Login.module.css';
import Input from '../common/input/Input';
import useInput from '../../utils/useInput';
import Button from '../common/button/Button';

const Login: React.FC = () => {
   const email = useInput('');
   const password = useInput('');

   const [emailError, setEmailError] = useState('');
   const [passwordError, setPasswordError] = useState('');
   const handleLogin = (e: React.FormEvent) => {
      e.preventDefault();

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

         />
         <Input
            value={password.value}
            onChange={password.onChange}
            onBlur={password.onBlur}
            placeholder="Password"
         />
         <Button type="submit">Log in</Button>
      </form>
   </div>



   );
};

export default Login;
