using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class Insurer
    {
        private int id;
        private String name;
        private String secondName;
        private String surname;
        private String phoneNumber;
        private String address;

        public Insurer() { }

        public Insurer(String name, String secondName, String surname, String phoneNumber, String address)
        {
            this.name = name;
            this.secondName = secondName;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public Insurer(int id, String name, String secondName, String surname, String phoneNumber, String address)
        {
            this.id = id;
            this.name = name;
            this.secondName = secondName;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
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


        //public int getId()
        //{
        //    return id;
        //}

        //public void setId(int id)
        //{
        //    this.id = id;
        //}

        //public String getName()
        //{
        //    return name;
        //}

        //public void setName(String name)
        //{
        //    this.name = name;
        //}

        //public String getSecondName()
        //{
        //    return secondName;
        //}

        //public void setSecondName(String secondName)
        //{
        //    this.secondName = secondName;
        //}

        //public String getSurname()
        //{
        //    return surname;
        //}

        //public void setSurname(String surname)
        //{
        //    this.surname = surname;
        //}

        //public String getPhoneNumber()
        //{
        //    return phoneNumber;
        //}

        //public void setPhoneNumber(String phoneNumber)
        //{
        //    this.phoneNumber = phoneNumber;
        //}

        //public String getAddress()
        //{
        //    return address;
        //}

        //public void setAddress(String address)
        //{
        //    this.address = address;
        //}
    }
}
