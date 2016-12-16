using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewLegalPaymentRequest
    {
        public bool registerNewLegalPaymentRequest(InsuranceCase insuranceCase, int legalClientId) 
        {
            bool result = true;
            InsurerDAO insurerDAO = new InsurerDAO();
            result = insurerDAO.registerNewLegalPaymentRequest(insuranceCase, legalClientId);
            return result;
        }
    }
}
