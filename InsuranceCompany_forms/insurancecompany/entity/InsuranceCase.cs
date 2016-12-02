using System;

namespace InsuranceCompany.entity
{
    class InsuranceCase
    {
        private String InsuranceCaseName;
        private decimal paymentProcent;

        public String getInsuranceCaseName() {
            return InsuranceCaseName;
        }
        public void setInsuranceCaseName(String InsuranceCaseName) {
            this.InsuranceCaseName = InsuranceCaseName;
        }

        public decimal getpaymentProcent()
        {
            return paymentProcent;
        }
        public void setpaymentProcent(decimal paymentProcent)
        {
            this.paymentProcent = paymentProcent;
        }

    }
}
