using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllIndividualPolicyPayments
    {
        public List<PolicyPayment> getAllIndividualPolicyPayments(Individual client)
        {
            List<PolicyPayment> list = new List<PolicyPayment>();
            InsurerDAO insurerDAO = new InsurerDAO();
            list = insurerDAO.getAllIndividualPolicyPayments(client);
            return list;
        }
    }
}
