using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllIndividualPaymentRequestsCommand
    {
        public List<PolicyPayment> getAllIndividualPaymentRequests(Individual individualPerson) 
        {
            List<PolicyPayment> individualPolicyPaymentsList = new List<PolicyPayment>();
            InsurerDAO insurerDAO = new InsurerDAO();
            individualPolicyPaymentsList = insurerDAO.getAllIndividualPaymentRequests(individualPerson);
            return individualPolicyPaymentsList;
        }
    }
}
