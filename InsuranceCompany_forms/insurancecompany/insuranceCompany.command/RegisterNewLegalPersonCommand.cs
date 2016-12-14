using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewLegalPersonCommand
    {
        public bool registerNewLegalPerson(LegalPerson legalPerson)
        {
            bool result = true;

            InsurerDAO insurerDAO = new InsurerDAO();
            result = insurerDAO.registerLegalPerson(legalPerson);

            return result;
        }
    }
}
