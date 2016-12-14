using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class InsurancePolicy
    {
        private int policyId;
        private InsuranceCategory category;
        private int cost;
        private int amount;
        private DateTime signDate;
        private DateTime expirationDate;
        private Client client;
        private List<InsuranceCase> insuranceCaseList;
        private Insurer insurer;

        public InsurancePolicy() { }

        public InsurancePolicy(InsuranceCategory category, Client client, int cost, int amount, DateTime signDate, DateTime expirationDate, List<InsuranceCase> insuranceCaseList, Insurer insurer)
        {
            this.category = category;
            this.client = client;
            this.cost = cost;
            this.amount = amount;
            this.signDate = signDate;
            this.expirationDate = expirationDate;
            this.insuranceCaseList = insuranceCaseList;
            this.insurer = insurer;
        }

        public InsurancePolicy(int id, InsuranceCategory category, Client client, int cost, int amount, DateTime signDate, DateTime expirationDate, List<InsuranceCase> insuranceCaseList, Insurer insurer)
        {
            this.policyId = id;
            this.category = category;
            this.client = client;
            this.cost = cost;
            this.amount = amount;
            this.signDate = signDate;
            this.expirationDate = expirationDate;
            this.insuranceCaseList = insuranceCaseList;
            this.insurer = insurer;
        }

        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }

        public InsuranceCategory Category
        {
            get { return category; }
            set { category = value; }
        }
       

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime SignDate
        {
            get { return signDate; }
            set { signDate = value; }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }
       
        public List<InsuranceCase> InsuranceCaseList
        {
            get { return insuranceCaseList; }
            set { insuranceCaseList = value; }
        }
       
        public Insurer Insurer
        {
            get { return insurer; }
            set { insurer = value; }
        }

    }
}
