using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class RegisterNewIndividualPersonCommand
    {
      public bool registerIndividualPerson(Individual individualPerson){
         bool result = true;
         InsurerDAO insurerDAO = new InsurerDAO();
         result = insurerDAO.registerIndividualPerson(individualPerson);  

        return result;
    }
    }
}
