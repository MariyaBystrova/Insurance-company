using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class RejectPaymentRequestCommand
    {
        public bool rejectPaymentRequest(PolicyPayment payment) 
        {
            bool result = true;
            InsurerDAO insurerDAO = new InsurerDAO();
            result = insurerDAO.rejectPaymentRequest(payment);
            return result;
        }
    }
}
