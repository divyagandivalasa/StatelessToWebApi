using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.service
{
    public class CustomerRepository : GenericRepository<CustomerModel, Customer>, ICustomerRepository
    {
        CustomerModel model;

        public CustomerRepository()
        {
            model = new CustomerModel();
        }

        public async Task<Customer> GetId(string custId)
        {
            var data = model.Customers.FirstOrDefault(x => x.CustomerID == custId);
            return data;
        }
    }
}
