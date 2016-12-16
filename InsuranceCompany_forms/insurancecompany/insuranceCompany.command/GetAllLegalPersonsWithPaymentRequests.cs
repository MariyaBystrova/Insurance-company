using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllLegalPersonsWithPaymentRequests
    {
        public List<LegalPerson> getAllLegalPersonsClientsWithPaymentRequests()
        {
            List<LegalPerson> list = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            list = insurerDAO.getAllLegalPersonsWithPaymentRequests();

            return list;
        }
    }
}
