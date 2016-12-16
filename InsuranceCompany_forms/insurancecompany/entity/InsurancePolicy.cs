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
        private decimal cost;
        private decimal amount;
        private DateTime signDate;
        private DateTime expirationDate;
        private Client client;
        private List<InsuranceCase> insuranceCaseList;
        private Insurer insurer;
        private decimal fullPayments;

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

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public decimal Amount
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

        public decimal FullPayments
        {
            get { return fullPayments; }
            set { fullPayments = value; }
        }


    }
}
