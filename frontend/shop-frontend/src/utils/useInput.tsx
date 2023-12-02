import { ChangeEvent, useState } from "react";

interface UserInputProps<T>{
  value:T;
  onChange:(e:ChangeEvent<HTMLInputElement>)=>void;
  onBlur:()=>void;
  isDirty:boolean;
}

  const useInput = <T,>(initialValue:T): UserInputProps<T>=>{
  const [value,setValue] = useState<T>(initialValue)
  const[isDirty,setDirty] = useState<boolean>(false);

  const onChange = (e:ChangeEvent<HTMLInputElement>) =>{
    setValue(e.target.value as unknown  as T);
  }
  const onBlur = () =>{
    setDirty(true)
  }
  return{
    value,onChange,onBlur,isDirty
  }
}

export default useInput;