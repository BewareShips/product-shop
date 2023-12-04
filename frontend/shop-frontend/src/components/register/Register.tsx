import React, { useEffect, useState } from 'react';
import styles from './Register.module.css';
import useInput from '../../hooks/useInput';
import Input from '../common/input/Input';
import Button from '../common/button/Button';

const Register: React.FC = () => {
   const firstName = useInput('',{isEmpty:true});
   const lastName = useInput('',{isEmpty:true});
   const email = useInput('' ,{isEmail:true});
   const password = useInput('',{minLength:6});
   const confirmPassword = useInput('',{minLength:6});
   const phoneNumber = useInput('',{isNumber:true});
   const address = useInput('',{isEmpty:true});

   const [isFormValid, setIsFormValid] = useState(false);

   useEffect(() => {
     setIsFormValid(
       firstName.valid &&
       email.valid &&
       password.valid &&
       phoneNumber.valid &&
       address.valid
     );
   }, [firstName.valid, email.valid, password.valid, phoneNumber.valid, address.valid]);



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
               errors={ firstName.errors}
               isDirty={firstName.isDirty}
            />
            <Input
               value={lastName.value}
               onChange={lastName.onChange}
               onBlur={lastName.onBlur}
               placeholder="Last Name"
               errors={lastName.errors}
               isDirty={lastName.isDirty}
            />
            <Input
               value={email.value}
               onChange={email.onChange}
               onBlur={email.onBlur}
               placeholder="Email"
               errors={email.errors}
               isDirty={email.isDirty}
            />
            <Input
               value={password.value}
               onChange={password.onChange}
               onBlur={password.onBlur}
               placeholder="Password"
               errors={password.errors}
               isDirty={password.isDirty}
            />
            <Input
               value={confirmPassword.value}
               onChange={confirmPassword.onChange}
               onBlur={confirmPassword.onBlur}
               placeholder="Confirm Password"
               errors={confirmPassword.errors}
               isDirty={confirmPassword.isDirty}
            />
            <Input
               value={phoneNumber.value}
               onChange={phoneNumber.onChange}
               onBlur={phoneNumber.onBlur}
               placeholder="Phone number"
               errors={phoneNumber.errors}
               isDirty={phoneNumber.isDirty}
            />
            <Input
               value={address.value}
               onChange={address.onChange}
               onBlur={address.onBlur}
               placeholder="Address"
               errors={address.errors}
               isDirty={address.isDirty}
            />
            <Button disabled={isFormValid} type="submit">Register</Button>
         </form>
      </div>
   );
};

export default Register;
