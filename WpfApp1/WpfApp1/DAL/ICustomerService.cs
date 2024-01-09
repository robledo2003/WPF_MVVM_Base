using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp1.Models;

namespace WpfApp1.DAL
{
    public interface ICustomerService
    {
        List<Customer> GetCustomer();
    }
}
