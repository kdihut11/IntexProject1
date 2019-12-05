using IntexProject.DAL;
using IntexProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntexProject.Controllers
{
    public class SalesRepController : Controller
    {
        private IntexProjectContext db = new IntexProjectContext();
        // GET: SalesRep
        public ActionResult Index()
        {
            List<CreateCustomer> CustomerInfo = new List<CreateCustomer>();
            CustomerInfo = db.Database.SqlQuery<CreateCustomer>("SELECT CustomerID, Address.AddressID, Login.LoginID, PaymentInfo.PaymentInfoID, CustFirstName, CustLastName, CustEmail, StreetAddress1, StreetAddress2, City, State, Country, Zip, Last4Digits, Username, Password FROM Customer JOIN Address ON Customer.AddressID = Address.AddressID JOIN PaymentInfo ON Customer.PaymentInfoID = PaymentInfo.PaymentInfoID JOIN Login ON Login.LoginID = Customer.LoginID").ToList();
            return View(CustomerInfo);
        }

        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(CreateCustomer customer)
        {
            Address newAddress = new Address() { StreetAddress1 = customer.StreetAddress1, StreetAddress2 = customer.StreetAddress2, City = customer.City, State = customer.State, Country = customer.Country, Zip = customer.Zip };
            db.Address.Add(newAddress);
            db.SaveChanges();
            PaymentInfo newPaymentInfo = new PaymentInfo() { Last4Digits = customer.Last4Digits, AddressID = newAddress.AddressID };
            db.PaymentInfo.Add(newPaymentInfo);
            db.SaveChanges();
            Login newLogin = new Login() { Username = customer.Username, Password = customer.Password};
            db.Login.Add(newLogin);
            db.SaveChanges();
            Customer newCustomer = new Customer() { CustFirstName = customer.CustFirstName, CustLastName = customer.CustLastName, CustEmail = customer.CustEmail, AddressID = newAddress.AddressID, PaymentInfoID = newPaymentInfo.PaymentInfoID, LoginID = newLogin.LoginID };
            db.Customer.Add(newCustomer);
            db.SaveChanges();
            return View("Index");
        }

        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            Customer myCust = db.Customer.Find(id);
            Address address = db.Address.Find(myCust.AddressID);
            PaymentInfo paymentInfo = db.PaymentInfo.Find(myCust.PaymentInfoID);
            Login login = db.Login.Find(myCust.LoginID);
            CreateCustomer create = new CreateCustomer() { CustomerID = myCust.CustomerID, LoginID = myCust.LoginID, PaymentInfoID = myCust.PaymentInfoID, AddressID = myCust.AddressID, CustFirstName = myCust.CustFirstName, CustLastName = myCust.CustLastName, CustEmail = myCust.CustEmail, StreetAddress1 = address.StreetAddress1, StreetAddress2 = address.StreetAddress2, City = address.City, State = address.State, Country = address.Country, Zip = address.Zip, Last4Digits = paymentInfo.Last4Digits, Username = login.Username, Password = login.Password };
            return View(create);
        }

        [HttpPost]
        public ActionResult EditCustomer(CreateCustomer create)
        {
            Customer cust = db.Customer.Find(create.CustomerID);
            Address address = db.Address.Find(create.AddressID);
            PaymentInfo paymentInfo = db.PaymentInfo.Find(create.PaymentInfoID);
            Login login = db.Login.Find(create.LoginID);

            if (create != null)
            {
                cust.CustFirstName = create.CustFirstName;
                cust.CustLastName = create.CustLastName;
                cust.CustEmail = create.CustEmail;


                address.StreetAddress1 = create.StreetAddress1;
                address.StreetAddress2 = create.StreetAddress2;
                address.Country = create.Country;
                address.City = create.City;
                address.State = create.State;
                address.Zip = create.Zip;

                paymentInfo.Last4Digits = create.Last4Digits;

                login.Password = create.Password;


                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}