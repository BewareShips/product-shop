import { useEffect, useState } from "react";

interface Validation {
   [key: string]: boolean | number;
}

const useValidation = <T,> (value:T,validations:Validation) =>{
   const [isEmpty,setIsEmpty] = useState(true);
   const[minLengthError,setMinLengthError] = useState(false);
   const[IsEmailError,setIsEmailError] = useState(false);
   const [isNumberError, setIsNumberError] = useState(false);
   const [isMatchError, setIsMatchError] = useState(false);


   useEffect(() => {
      setIsEmpty(!Boolean(value));
    }, [value]);
    
   useEffect(()=>{
      for(const validation in validations){
         switch(validation){
            case 'minLength':
               if(typeof(value) == "string" && typeof validations[validation] === 'number'){
               value.length < Number(validations[validation]) ? setMinLengthError(true):setMinLengthError(false)
               }
               break;
            case 'isEmpty':
                setIsEmpty(!Boolean(value))
                console.log(!Boolean(value))
               break;
               case 'isEmail':
                  if(typeof(value) == "string"){
                  const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
                  setIsEmailError(!emailRegex.test(value));
                  }
               break;
               case 'isNumber':
                  if(typeof value == "string"){
                     const numberRegex = /^\d+$/;
                     setIsNumberError(!numberRegex.test(value));
                  }
                  break;
               case 'IsMatch':
                  if(value !==  validations[validation]){
                     setIsMatchError(true);
                  }
                  break;
            default:break;
         }
      }
   },[value])
   return {isEmpty,minLengthError,IsEmailError,isNumberError,isMatchError}
}

export default useValidation;