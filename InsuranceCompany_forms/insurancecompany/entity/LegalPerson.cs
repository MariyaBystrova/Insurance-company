using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class LegalPerson
    {
        private String companyName;
        private String uniqueNumber;
        private String directorName;
        private String directorSecondName;
        private String directorSurname;
        private String accountantName;
        private String accountantSecondName;
        private String accountantSurname;
        private String companyAddress;
        private String companyPhoneNumber;

        public LegalPerson() { }

        public LegalPerson(String companyName, String uniqueNumber, String directorName, String directorSecondName, String directorSurname, String accountantName, String accountantSecondName, String accountantSurname, String companyAddress, String companyPhoneNumber)
        {
            this.companyName = companyName;
            this.uniqueNumber = uniqueNumber;
            this.directorName = directorName;
            this.directorSecondName = directorSecondName;
            this.directorSurname = directorSurname;
            this.accountantName = accountantName;
            this.accountantSecondName = accountantSecondName;
            this.accountantSurname = accountantSurname;
            this.companyAddress = companyAddress;
            this.companyPhoneNumber = companyPhoneNumber;

        }

        public String CompanyPhoneNumber
        {
            get { return companyPhoneNumber; }
            set { companyPhoneNumber = value; }
        }

        public String CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }

        public String AccountantSurname
        {
            get { return accountantSurname; }
            set { accountantSurname = value; }
        }

        public String AccountantSecondName
        {
            get { return accountantSecondName; }
            set { accountantSecondName = value; }
        }

        public String AccountantName
        {
            get { return accountantName; }
            set { accountantName = value; }
        }

        public String DirectorSurname
        {
            get { return directorSurname; }
            set { directorSurname = value; }
        }

        public String DirectorSecondName
        {
            get { return directorSecondName; }
            set { directorSecondName = value; }
        }

        public String DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        }

        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        
        public String UniqueNumber
        {
            get { return uniqueNumber; }
            set { uniqueNumber = value; }
        }
        
    }
}
