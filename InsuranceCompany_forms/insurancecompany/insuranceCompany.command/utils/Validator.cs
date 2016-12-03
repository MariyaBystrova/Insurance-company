using System;
using InsuranceCompany.entity;

namespace InsuranceCompany.insuranceCompany.command.utils
{
    class Validator
    {
        public static bool validateNewInsuranceCaseInfo(InsuranceCase insuranceCase) {
            bool result = true;
            if (String.IsNullOrEmpty(insuranceCase.getInsuranceCaseName()))
            {
                result = false;
            }
            if (insuranceCase.getPaymentProcent() == 0)
            {
                result = false;
            }
            return result;
        }
    }
}
