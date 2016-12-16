using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllLegalPaymentRequestsCommand
    {
        public List<PolicyPayment> getAllLegalPaymentRequests(LegalPerson legalPerson) 
        {
            InsurerDAO insurerDAO = new InsurerDAO();
            List<PolicyPayment> legalPaymentRequests = insurerDAO.getAllLegalPaymentRequests(legalPerson);
            return legalPaymentRequests;
            
        }
    }
}
