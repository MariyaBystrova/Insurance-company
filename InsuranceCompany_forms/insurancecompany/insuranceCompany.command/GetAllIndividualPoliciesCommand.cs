using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllIndividualPoliciesCommand
    {
        public List<InsurancePolicy> getallIndividualPolicies(Individual individualPerson)
        {
            List<InsurancePolicy> individualPolicyList = new List<InsurancePolicy>();
            InsurerDAO insurerDAO = new InsurerDAO();
            individualPolicyList = insurerDAO.getAllIndividulPolicies(individualPerson);
            return individualPolicyList;
        }
    }
}
