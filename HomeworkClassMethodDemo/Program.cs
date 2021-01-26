using System;
using System.Collections.ObjectModel;

namespace HomeworkClassMethodDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer(id:1,firstName:"Ömer",lastName:"Küçük",sex:true);
            Customer customer2 = new Customer(id: 2, firstName: "Miss", lastName: "Lady", sex: false);
            Customer customer3 = new Customer(id: 3, firstName: "Mister", lastName: "Gentlemen", sex: true);

            ObservableCollection<Customer> observable = new ObservableCollection<Customer> {customer,customer2};
               
            
            foreach (var item in observable)
            {
                Console.WriteLine(item);
            }

            observable.Update(0, customer3);

            Console.WriteLine(observable[0]);

            observable.Delete(customer2);
            

            foreach (var item in observable)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
