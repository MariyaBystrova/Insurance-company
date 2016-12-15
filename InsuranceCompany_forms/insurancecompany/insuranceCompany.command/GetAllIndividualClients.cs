using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllIndividualClients
    {
        public List<Individual> getAllLegalPersonInfo()
        {
            List<Individual> individualList = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            individualList = insurerDAO.getAllIndividualInfo();
            
            return individualList;
        }
    }
}
