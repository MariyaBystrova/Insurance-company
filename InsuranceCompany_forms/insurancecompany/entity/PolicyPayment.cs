using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class PolicyPayment
    {
        private int id;
        private InsurancePolicy policy;
        private InsuranceCase insuranceCase;
        private DateTime paymentApplicationDate;
        private decimal paymentAmount;
        private DateTime paymentDate;
        private bool paymentRefusal;

        public PolicyPayment() { }

        public PolicyPayment(InsurancePolicy policy, InsuranceCase insuranceCase, DateTime paymentApplicationDate, int paymentAmount, DateTime paymentDate, bool paymentRefusal)
        {
            this.policy = policy;
            this.insuranceCase = insuranceCase;
            this.paymentApplicationDate = paymentApplicationDate;
            this.paymentAmount = paymentAmount;
            this.paymentDate = paymentDate;
            this.paymentRefusal = paymentRefusal;
        }

        public override string ToString()
        {
            return policy.PolicyId+ " / "+ policy.Category + " / "+insuranceCase + " / "+ paymentAmount;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool PaymentRefusal
        {
            get { return paymentRefusal; }
            set { paymentRefusal = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        public DateTime PaymentApplicationDate
        {
            get { return paymentApplicationDate; }
            set { paymentApplicationDate = value; }
        }

        public InsuranceCase InsuranceCase
        {
            get { return insuranceCase; }
            set { insuranceCase = value; }
        }

        public InsurancePolicy Policy
        {
            get { return policy; }
            set { policy = value; }
        }
    }
}
