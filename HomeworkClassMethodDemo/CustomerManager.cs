using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HomeworkClassMethodDemo
{
    internal static class CustomerManager
    { 

        public static ObservableCollection<Customer> Add(this ObservableCollection<Customer> observableCustomer, Customer customer)
        {
            observableCustomer.Add(customer);

            return observableCustomer;  
        }

        public static ObservableCollection<Customer> Update(this ObservableCollection<Customer> observableCustomer, int index, Customer customer)
        {
            observableCustomer[index] = customer;

            return observableCustomer;
        }

        public static ObservableCollection<Customer> Delete(this ObservableCollection<Customer> observableCustomer, Customer customer)
        {
            if (observableCustomer.Remove(customer) == false)  //Delete first index
            {
                throw new Exception("İtem is not found");
            }

            return observableCustomer;

        }
    }
}
