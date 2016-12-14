using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.entity
{
    class InsuranceCategory
    {
        private int id;
        private String name;
        private int maxPoliceCost;

        public InsuranceCategory() { }

        public InsuranceCategory(String name)
        {
            this.name = name;
        }
        public InsuranceCategory(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public int MaxPoliceCost
        {
            get { return maxPoliceCost; }
            set { maxPoliceCost = value; }
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        
        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public override string ToString()
        {
            return  Name;
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
    }
}
