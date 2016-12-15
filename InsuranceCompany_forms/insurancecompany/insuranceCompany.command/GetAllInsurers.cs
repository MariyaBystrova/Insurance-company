using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllInsurers
    {
        public List<Insurer> getAllInsurers()
        {
            List<Insurer> insurerList = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            insurerList = insurerDAO.getAllInsurersInfo();

            return insurerList;
        }
    }
}
