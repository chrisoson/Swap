﻿import React, {useEffect, useState} from 'react';

interface RegisterFormData{
  email: string;
  password: string;
  firstName: string;
  middleName?: string;
  lastName: string;
  profilePicture?: File;
}

const UseRegister = () => {
  const [step, setStep] = useState(1);

  const [formData, setFormData] = useState<RegisterFormData>({
    email: '',
    password: '',
    firstName: '',
    middleName: '',
    lastName: '',
    profilePicture: undefined
  });

  const nextStep = () => {
    setStep(prevStep => prevStep + 1);
  };

  const handleFormData = (newData: any) => {
    setFormData(prevData => ({
      ...prevData,
      ...newData
    }));
  };

  const submitRegisterForm = () => {
    //submit the form to the api
  };
  return {step, nextStep, handleFormData, submitRegisterForm};
};

export default UseRegister;