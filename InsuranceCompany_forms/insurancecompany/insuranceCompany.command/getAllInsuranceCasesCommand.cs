using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class getAllInsuranceCasesCommand
    {
        public List<InsuranceCase> getAllInsuranceCases()
        {
            List<InsuranceCase> caseList = new List<InsuranceCase>();
            InsurerDAO insurerDAO = new InsurerDAO();
            caseList = insurerDAO.getAllInsuranceCases();
            return caseList;
        }
    }
}
