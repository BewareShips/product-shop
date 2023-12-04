import { ChangeEvent, useState } from 'react';
import useValidation from './useValidations';

interface UserInputProps<T> {
   value: T;
   onChange: (e: ChangeEvent<HTMLInputElement>) => void;
   onBlur: () => void;
   isDirty: boolean;
   errors?:string[]
   valid: boolean;
}

interface Validation {
   [key: string]: boolean | number;
}

const useInput = <T,>(
   initialValue: T,
   validations?: Validation
): UserInputProps<T> => {
   const [value, setValue] = useState<T>(initialValue);
   const [isDirty, setDirty] = useState<boolean>(false);


   const onChange = (e: ChangeEvent<HTMLInputElement>) => {
    const newValue = e.target.value as unknown as T;
    if(newValue !== value){
      setValue(newValue);
    }
   };
   const onBlur = () => {
    if(!isDirty){
      setDirty(true);
    }
   };
   const errors: string[] = [];

   if(validations){
    const { isEmpty, minLengthError, IsEmailError, isNumberError } =
      useValidation(value, validations);

      if (isEmpty) errors.push('Field cannot be empty');
      if (minLengthError && typeof validations.minLength === 'number') {
         errors.push(`At least ${validations.minLength} characters`);
      }
      if (IsEmailError) errors.push('Invalid email format');
      if (isNumberError) errors.push('Value must be a number');
   }


   const valid = errors.length > 0;
   return {
      value,
      onChange,
      onBlur,
      isDirty,
      errors,
      valid
   };
};

export default useInput;
