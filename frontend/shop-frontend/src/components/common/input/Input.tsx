import React from 'react';
import styles from './Input.module.css';

interface InputProps extends React.InputHTMLAttributes<HTMLInputElement> {
  error?: boolean;
  errorMessage?: string;
}

const Input: React.FC<InputProps> = (props) => {
  const {
    error = false,
    errorMessage = '',
    className,
    ...otherprops
  } = props;
  return (
    <div className={`styles.inputContainer} ${className}`}>
      <input
        className={`${styles.input } ${error ?  styles.input__error : ""}`}  {...otherprops}
      />
      {error && <span className={styles.errorMessage}>{errorMessage}</span>}
    </div>

  );
};

export default Input;