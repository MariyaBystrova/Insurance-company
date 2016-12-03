using System;

namespace InsuranceCompany.entity
{
    class InsuranceCase
    {
        private int insuranceCaseId;
        private String insuranceCaseName;
        private decimal paymentProcent;
        private String insuranceCategoryName;
        private int insuranseCategoryId;


        public int getInsuranseCategoryId() {
            return this.insuranseCategoryId;
        }

        public void setInsuranseCategoryId(int insuranseCategoryId) {
            this.insuranseCategoryId = insuranseCategoryId;
        }

        public String getInsuranceCategoryName() {
            return this.insuranceCategoryName;
        }

        public void setInsuranceCategoryName(String insuranceCategoryName) {
            this.insuranceCategoryName = insuranceCategoryName;
        }

        public int getInsuranceCaseID() {
            return this.insuranceCaseId;
        }
        public void setInsuranceCaseId(int insuranceCaseId) {
            this.insuranceCaseId = insuranceCaseId;
        }
        public String getInsuranceCaseName() {
            return insuranceCaseName;
        }

        public void setInsuranceCaseName(String InsuranceCaseName) {
            this.insuranceCaseName = InsuranceCaseName;
        }

        public decimal getPaymentProcent()
        {
            return paymentProcent;
        }
        public void setPaymentProcent(decimal paymentProcent)
        {
            this.paymentProcent = paymentProcent;
        }

    }
}
