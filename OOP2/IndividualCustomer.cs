using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İnheritance
    internal class IndividualCustomer : Customer
    {
        public string IdentityNo { get; set; } //Identity Number is string becouse we will not do mathematical operations  
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
