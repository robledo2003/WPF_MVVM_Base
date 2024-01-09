using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.DAL;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region  Properties

        private List<Customer> customers;

        public List<Customer> Customers
        {
            get { return customers; }
            set
            {
                if (customers == value)
                {
                    return;
                }
                customers = value;
                OnPropertyChanged("Customers");
            }
        }

        #endregion Properties

        #region Commands
        private ICommand customerCommand;

        public ICommand CustomerCommand
        { get
            {
                if (customerCommand == null)
                {
                    customerCommand = new RelayCommand(param=>this.CusomerCommandExecute(param));
                }
                return customerCommand;
            }
        }

        #endregion Commands

        public MainWindowViewModel() 
        {
            
        }

        private void CusomerCommandExecute(object param)
        {
            var customerService = new CustomerService();
            var result = customerService.GetCustomer();
            Customers = new List<Customer>(result);
        }
    }
}
