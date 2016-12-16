using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllLegalPersonPoliciesCommand
    {
        public List<InsurancePolicy> getAllLegalPersonPolicies(LegalPerson legalPerson) 
        {
            List<InsurancePolicy> legalPolicyList = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            legalPolicyList = insurerDAO.getAllLegalPersonPolicies(legalPerson);
            return legalPolicyList;
        }
    }
}
