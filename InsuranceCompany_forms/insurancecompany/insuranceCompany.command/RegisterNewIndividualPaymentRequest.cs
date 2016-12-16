using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewIndividualPaymentRequest
    {
        public bool registerNewIndividualPaymentRequest(InsuranceCase insuranceCase, int individualClientId)
        {
            InsurerDAO insurerDAO = new InsurerDAO();
            bool result = insurerDAO.registerNewIndividualPaymentRequest(insuranceCase, individualClientId);
            return result;

            
        }
    }
}
