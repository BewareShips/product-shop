import React from 'react'
import styles from './Button.module.css';

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement>{
  loading?:boolean;
}

const Button:React.FC<ButtonProps> = (props) => {
  const {
    children,
    loading = false,
    className,
    disabled,
    ...otherProps
  } = props;
  return (
    <button className={`${styles.button} ${className}`} disabled={disabled || loading} {...otherProps}>
      {loading ? 'Loading...' : children}
    </button>
  )
}

export default Button