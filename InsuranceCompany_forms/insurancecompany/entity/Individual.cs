using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class Individual
    {
        private String name;
        private String secondName;
        private String surname;
        private DateTime birthDate;
        private String sex;
        private String photo;
        private int drivingExperience;
        private String address;
        private String phoneNumber;

        public Individual() { }

        public Individual(String name, String secondName, String surname, DateTime birthDate, String sex, String photo, int drivingExperience, String address, String phoneNumber)
        {
            this.name = name;
            this.secondName = secondName;
            this.surname = surname;
            this.birthDate = birthDate;
            this.sex = sex;
            this.photo = photo;
            this.drivingExperience = drivingExperience;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public int DrivingExperience
        {
            get { return drivingExperience; }
            set { drivingExperience = value; }
        }

        public String Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public String Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
