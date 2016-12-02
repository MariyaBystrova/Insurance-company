using System;
using InsuranceCompany.insuranceCompany.DAO.impl;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.command.utils;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewInsuranceCaseCommand
    {
        public bool registerNewInsuranceCase(InsuranceCase insuranceCase) {
            bool result = true;
            if (!Validator.validateNewInsuranceCaseInfo(insuranceCase)) {
                throw new ArgumentException();
            }

            InsurerDAO insurerDAO = new InsurerDAO();
           result =  insurerDAO.registerNewInsuranceCase(insuranceCase);  

            return result;
        }
    }
}
