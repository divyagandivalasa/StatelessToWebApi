using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.service
{
    public interface ICustomerRepository
    {
        Task<Customer> GetId(string custId);
    }
}
