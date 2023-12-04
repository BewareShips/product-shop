import React from 'react';
import styles from './Input.module.css';


interface InputProps extends React.InputHTMLAttributes<HTMLInputElement> {
   errors?: string[];
   isDirty:boolean;
}

const Input: React.FC<InputProps> = (props) => {
   const { errors, className,isDirty, ...otherprops } = props;

   return (
      <div className={`${styles.inputContainer} ${className}`}>
         {isDirty && errors && errors.length > 0 && (
            <div className={styles.errorMessages}>
               {errors.map((err, index) => (
                  <span key={index} className={styles.errorMessage}>
                     {err}
                     <br/>
                  </span>
               ))}
            </div>
         )}
         <input
            className={`${styles.input} ${
              isDirty && errors && errors.length > 0 ? styles.input__error : ''
            }`}
            {...otherprops}
         />
      </div>
   );
};

export default React.memo(Input);
