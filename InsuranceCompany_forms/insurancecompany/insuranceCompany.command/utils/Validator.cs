using System;
using InsuranceCompany.entity;

namespace InsuranceCompany.insuranceCompany.command.utils
{
    class Validator
    {
        public static bool validateNewInsuranceCaseInfo(InsuranceCase insuranceCase) {
            bool result = true;
            if (String.IsNullOrEmpty(insuranceCase.InsuranceCaseName))
            {
                result = false;
            }
            if (insuranceCase.PaymentProcent == 0)
            {
                result = false;
            }
            return result;
        }

        public static bool validateNewInsuranceCategoryInfo(String categoryName)
        {
            bool result = true;
            if (String.IsNullOrEmpty(categoryName)) {
                result = false;
            }
            return result;
        }
    }
}
