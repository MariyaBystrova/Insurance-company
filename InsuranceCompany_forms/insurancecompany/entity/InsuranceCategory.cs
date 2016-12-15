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

        public override string ToString()
        {
            return Name;
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

    }
}
