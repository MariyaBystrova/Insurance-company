using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllIndividualWithPaymentRequests
    {
        public List<Individual> getAllIndividualClientsWithPaymentRequests()
        {
            List<Individual> individualList = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            individualList = insurerDAO.getAllIndividualWithPaymentRequests();

            return individualList;
        }
    }
}
