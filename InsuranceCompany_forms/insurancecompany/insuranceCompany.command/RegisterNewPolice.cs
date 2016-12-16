using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewPolice
    {
        public bool registerNewPolice(InsurancePolicy policy)
        {
            bool result = false;
            InsurerDAO insurerDAO = new InsurerDAO();

            if(policy.Client is LegalPerson)
            {
                result = insurerDAO.registerPolicyForLegalPerson(policy);
            }
            if (policy.Client is Individual)
            {
                result = insurerDAO.registerPolicyForIndividual(policy);
            }

            return result;
        }
    }
}
