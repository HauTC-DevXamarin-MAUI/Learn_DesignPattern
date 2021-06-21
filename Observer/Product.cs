using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    class Product : ObseverClass
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Customer> lstCustomer = new List<Customer>();
        public override void ObseverInfo(string info)
        {
            foreach (Customer item in lstCustomer)
            {
                if (item != null)
                {
                    item.ObseverInfo(name);
                }
            }
        }
        public void AddCustomer(Customer cus)
        {
            if (cus != null)
            {
                lstCustomer.Add(cus);
            }
        }
        public void RemoveCustomer(Customer cus)
        {
            if (cus != null)
            {
                lstCustomer.Add(cus);
            }
        }

        public Product(string name)
        {
            this.name = name;
        }
        
    }
}
