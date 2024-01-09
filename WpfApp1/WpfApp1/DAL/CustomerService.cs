using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.DAL
{
    public class CustomerService: ICustomerService
    {
        public  List<Customer> GetCustomer()
        {
            var customers = new List<Customer>();
            for (int i = 0; i < 20; i++)
            {
                customers.Add(new Customer()
                {
                    Id = i,
                    FirstName = Guid.NewGuid().ToString(),
                    SecondName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    IsEnable = i % 2 == 0 ? true:false,
                    LastLogin = DateTime.Now.AddDays(i)

                }
                ) ;
            }
            return customers;
        }
    }
}
