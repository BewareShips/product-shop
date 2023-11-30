/* eslint-disable @typescript-eslint/no-unused-vars */
import React, { useState } from 'react'
import Input from '../../components/common/input/Input';


const Login:React.FC = () => {
  const [email,setEmail] = useState('');
  const [password,setPassword] = useState('');
  const [emailError,setEmailError] = useState('');
  const [passwordError,setPasswordError] = useState('');
  const handleLogin = () =>{

}
  
  return (
    <div>
      <h1>Login</h1>
      <Input 
        value={email}
        onChange={(e)=>setEmail(e.target.value)}
        placeholder="Email"
        error={!!emailError}
        errorMessage={emailError}
      
      />
      <Input 
        value={password}
        onChange={(e)=>setPassword(e.target.value)}

        placeholder="Password"
        error={!!passwordError}
        errorMessage={passwordError}
      />
    </div>
  )
}

export default Login