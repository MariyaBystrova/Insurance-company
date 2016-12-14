using InsuranceCompany.insuranceCompany.command.utils;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewInsuranceCategoryCommand
    {
        public bool registerNewInsuranceCategory (String categoryName)
        {
            bool result = true;
            if (!Validator.validateNewInsuranceCategoryInfo(categoryName))
            {
                throw new ArgumentException();
            }

            InsurerDAO insurerDAO = new InsurerDAO();
            result = insurerDAO.registerNewInsuranceCategory(categoryName);

            return result;
        }
    }
}
