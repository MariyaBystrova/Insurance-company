using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class Client
    {
        private List<InsurancePolicy> insurancePolicyList;

        public Client() { }

       
        public List<InsurancePolicy> InsurancePolicyList
        {
            get { return insurancePolicyList; }
            set { insurancePolicyList = value; }
        }

       

    }
}
