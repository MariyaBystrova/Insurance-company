﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllLegalClientsInfo
    {
        public List<LegalPerson> getAllLegalPersonInfo()
        {
            List<LegalPerson> legalPersonList = null;
            InsurerDAO insurerDAO = new InsurerDAO();
            legalPersonList = insurerDAO.getAllLegalPersonInfo();
            return legalPersonList;
        }
    }
}
