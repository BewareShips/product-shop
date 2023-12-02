import React from 'react';
import styles from './Register.module.css';
import useInput from '../../utils/useInput';
import Input from '../common/input/Input';
import Button from '../common/button/Button';

const Register: React.FC = () => {
   const firstName = useInput('');
   const lastName = useInput('');
   const email = useInput('');
   const password = useInput('');
   const phoneNumber = useInput('');
   const address = useInput('');

   const handleSubmit = (e: React.FormEvent) => {
      e.preventDefault();
    };
   return (
      <div className={`${styles.formContainer}`}>
         <h2>Register</h2>
         <form onSubmit={handleSubmit}>
            <Input
               value={firstName.value}
               onChange={firstName.onChange}
               onBlur={firstName.onBlur}
               placeholder="First Name"
            />
            <Input
               value={lastName.value}
               onChange={lastName.onChange}
               onBlur={lastName.onBlur}
               placeholder="Last Name"
            />
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
            <Input
               value={phoneNumber.value}
               onChange={phoneNumber.onChange}
               onBlur={phoneNumber.onBlur}
               placeholder="Phone number"
            />
            <Input
               value={address.value}
               onChange={address.onChange}
               onBlur={address.onBlur}
               placeholder="Address"
            />
            <Button type="submit">Register</Button>
         </form>
      </div>
   );
};

export default Register;
