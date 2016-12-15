using System;

namespace InsuranceCompany.entity
{
    class InsuranceCase
    {
        private int insuranceCaseId;
        private String insuranceCaseName;
        private decimal paymentProcent;
        private InsuranceCategory insuranceCategory;

        public InsuranceCase(){}

        public InsuranceCase(int insuranceCaseId, String insuranceCaseName, decimal paymentProcent, InsuranceCategory insuranceCategory)
        {
            this.insuranceCaseId=insuranceCaseId;
            this.insuranceCaseName = insuranceCaseName;
            this.paymentProcent = paymentProcent;
            this.insuranceCategory = insuranceCategory;
        }

        public InsuranceCategory InsuranceCategory
        {
            get { return insuranceCategory; }
            set { insuranceCategory = value; }
        }

        public int InsuranceCaseId
        {
            get { return insuranceCaseId; }
            set { insuranceCaseId = value; }
        }

        public String InsuranceCaseName
        {
            get { return insuranceCaseName; }
            set { insuranceCaseName = value; }
        }

        public decimal PaymentProcent
        {
            get { return paymentProcent; }
            set { paymentProcent = value; }
        }
       
    }
}
