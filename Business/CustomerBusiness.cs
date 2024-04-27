using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {
        public List<Customer> GetCustom()
        {
            List<Customer> custom = new List<Customer>();
            CustomerData data = new CustomerData();
            custom = data.GetCustom();
            return custom;
        }
    }
}
