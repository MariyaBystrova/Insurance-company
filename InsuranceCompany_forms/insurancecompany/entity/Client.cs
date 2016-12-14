using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class Client
    {
        private int id;
        private List<InsurancePolicy> insurancePolicyList;

        public Client() { }

        public Client(int id, List<InsurancePolicy> insurancePolicyList)
        {
            this.id = id;
            this.insurancePolicyList = insurancePolicyList;
        }

        public int Id 
        {
            set { id = value;}
            get{return this.id;}
        }

        public List<InsurancePolicy> InsurancePolicyList
        {
            get { return insurancePolicyList; }
            set { insurancePolicyList = value; }
        }

       

        //public int getId()
        //{
        //    return id;
        //}

        //public void setId(int id) 
        //{
        //    this.id = id;
        //}

        //public List<InsurancePolicy> getInsurancePolicyList()
        //{
        //    return insurancePolicyList;
        //}

        //public void setInsurancePolicyList(List<InsurancePolicy> insurancePolicyList)
        //{
        //    this.insurancePolicyList = insurancePolicyList;
        //}
    }
}
