using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    public class CreateCustomer
    {
        
        public int CustomerID { get; set; }
        
        public int AddressID { get; set; }

        public int LoginID { get; set; }

        public int PaymentInfoID { get; set; }

        [DisplayName("First Name:")]
        public string CustFirstName { get; set; }

        [DisplayName("Last Name:")]
        public string CustLastName { get; set; }

        [DisplayName("Email:")]
        public string CustEmail { get; set; }

        [DisplayName("Street Address 1:")]
        public string StreetAddress1 { get; set; }

        [DisplayName("Street Address 2:")]
        public string StreetAddress2 { get; set; }

        [DisplayName("City:")]
        public string City { get; set; }

        [DisplayName("State:")]
        public string State { get; set; }

        [DisplayName("Country:")]
        public string Country { get; set; }

        [DisplayName("Zip:")]
        public string Zip { get; set; }

        [DisplayName("Last Four Digits of Credit Card:")]
        public int Last4Digits { get; set; }

        [DisplayName("Username:")]
        public string Username { get; set; }

        [DisplayName("Password:")]
        public string Password { get; set; }

    }
}