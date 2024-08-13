using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_project
{
    public class Customer
    {


        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } 
        public bool DanmarkMember { get; set; }
        public string CPR { get; set; }
        
       
        public Customer(string Firstname, string Lastname, string Birthdate, string Address, string PhoneNumber, bool DanmarkMember, string CPR)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Birthdate = Birthdate;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.DanmarkMember = DanmarkMember;
            this.CPR = CPR;
        }

        public List<Customer> customerlist = new List<Customer>
           {
           new Customer("Mark","Christensen", "05/04/92", "Herningvej 162", "53662214", false, "0504921689")
           };

    }
}
