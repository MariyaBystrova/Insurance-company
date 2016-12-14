using InsuranceCompany.entity;
using InsuranceCompany.insuranceCompany.DAO.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.insuranceCompany.command
{
    class GetAllInsuranceCategoriesCommand{
    
          public List<InsuranceCategory> getAllInsuranceCategories()
        {
            List<InsuranceCategory> categoryList = new List<InsuranceCategory>();
            InsurerDAO insurerDAO = new InsurerDAO();
            categoryList = insurerDAO.getAllPoliceCategories();
            return categoryList;
        }
    }
}
