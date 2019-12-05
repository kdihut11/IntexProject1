using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexProject.Models
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        [DisplayName("Role ID:")]
        public int RoleID { get; set; }

        [DisplayName("Role ID:")]
        public string RoleName { get; set; }
    }

    [Table("Login")]
    public class Login
    {
        [Key]
        [DisplayName("Login ID:")]
        public int LoginID { get; set; }

        [DisplayName("Username:")]
        public string Username { get; set; }

        [DisplayName("Password:")]
        public string Password { get; set; }

        [DisplayName("Role ID:")]
        public int RoleID { get; set; }
    }

    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DisplayName("Customer ID:")]
        public int CustomerID { get; set; }

        [DisplayName("First Name:")]
        public string CustFirstName { get; set; }

        [DisplayName("Last Name:")]
        public string CustLastName { get; set; }

        [DisplayName("Email:")]
        public string CustEmail { get; set; }

        [DisplayName("Login ID:")]
        public int LoginID { get; set; }

        [DisplayName("Address ID:")]
        public int AddressID { get; set; }

        [DisplayName("Payment Info ID:")]
        public int PaymentInfoID { get; set; }

    }

    [Table("Address")]
    public class Address
    {
        [Key]
        [DisplayName("Address ID:")]
        public int AddressID { get; set; }

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

    }

    [Table("PaymentInfo")]
    public class PaymentInfo
    {
        [Key]
        [DisplayName("Payment Info ID:")]
        public int PaymentInfoID { get; set; }

        [DisplayName("Last 4 Digits of Credit Card:")]
        public int Last4Digits { get; set; }

        [DisplayName("AddressID:")]
        public int AddressID { get; set; }

    }

    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        [DisplayName("Invoice ID:")]
        public int InvoiceID { get; set; }

        [DisplayName("Invoice Amount:")]
        public decimal InvoiceAmount { get; set; }

        [DisplayName("Payment Info ID:")]
        public int PaymentInfoID { get; set; }

    }

    [Table("InvoiceDiscount")]
    public class InvoiceDiscount
    {
        [Key, Column(Order = 1)]
        [DisplayName("Invoice ID:")]
        public int InvoiceID { get; set; }

        [Key, Column(Order = 2)]
        [DisplayName("Discount ID:")]
        public int DiscountID { get; set; }

    }

    [Table("Discounts")]
    public class Discounts
    {
        [Key]
        [DisplayName("Discount ID:")]
        public int DiscountID { get; set; }

        [DisplayName("Discount Type:")]
        public string DiscountType { get; set; }

        [DisplayName("Discount Percent:")]
        public decimal DiscountPercent { get; set; }

    }

    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        [DisplayName("Work Order ID:")]
        public int WorkOrderID { get; set; }

        [DisplayName("Order Notes:")]
        public string OrderNotes { get; set; }

        [DisplayName("Customer ID:")]
        public int CustomerID { get; set; }

        [DisplayName("LT Number:")]
        public int LTNumber { get; set; }
    }

    [Table("Compound")]
    public class Compound
    {
        [Key]
        [DisplayName("LT Number:")]
        public int LTNumber { get; set; }

        [DisplayName("Compound Name:")]
        public string CompoundName { get; set; }

        [DisplayName("Qty Of Samples:")]
        public int QtyOfSamples { get; set; }

        [DisplayName("Date Arrived:")]
        public DateTime DateArrived { get; set; }

        [DisplayName("Received By:")]
        public int EmpID { get; set; }

        [DisplayName("Weight:")]
        public decimal Weight { get; set; }

        [DisplayName("Maximum Dosage:")]
        public decimal MaxDose { get; set; }

        [DisplayName("Molecular Mass:")]
        public decimal MolecularMass { get; set; }
    }

    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DisplayName("Employee ID:")]
        public int EmpID { get; set; }

        [DisplayName("First Name:")]
        public string EmpFirstName { get; set; }

        [DisplayName("Last Name:")]
        public string EmpLastName { get; set; }

        [DisplayName("Date of Birth:")]
        public DateTime DOB { get; set; }

        [DisplayName("Address ID:")]
        public int AddressID { get; set; }

        [DisplayName("Login ID:")]
        public int LoginID { get; set; }

    }

    [Table("CompoundSample")]
    public class CompoundSample
    {
        [Key, Column(Order = 1)]
        [DisplayName("LT Number:")]
        public int LTNumber { get; set; }

        [Key, Column(Order = 2)]
        [DisplayName("Sequence Code:")]
        public int SequenceCode { get; set; }

    }

    [Table("Sample")]
    public class Sample
    {
        [Key]
        [DisplayName("Sequence Code:")]
        public int SequenceCode { get; set; }

        [DisplayName("Appearance:")]
        public string Appearance { get; set; }

        [DisplayName("Test ID:")]
        public int TestID { get; set; }
    }

    [Table("Test")]
    public class Test
    {
        [Key]
        [DisplayName("Test ID")]
        public int TestID { get; set; }

        [DisplayName("Test Description:")]
        public string TestDesc { get; set; }
    }

    [Table("Files")]
    public class Files
    {
        [Key]
        [DisplayName("File ID:")]
        public int FileID { get; set; }

        [DisplayName("File Path:")]
        public string FilePath { get; set; }
    }

    [Table("Cost")]
    public class Cost
    {
        [Key]
        [DisplayName("Cost ID:")]
        public int CostID { get; set; }

        [DisplayName("Employee ID:")]
        public int EmpID { get; set; }

        [DisplayName("Hours worked:")]
        public int Hours { get; set; }
    }

    [Table("SampleTests")]
    public class SampleTests
    {
        [Key, Column(Order = 1)]
        [DisplayName("Sequence Code:")]
        public int SequenceCode { get; set; }

        [Key, Column(Order = 2)]
        [DisplayName("Test ID:")]
        public int TestID { get; set; }

        [DisplayName("Due Date:")]
        public DateTime TestDueDate { get; set; }

        [DisplayName("Test Status:")]
        public bool Status { get; set; }

        
        [DisplayName("Cost ID:")]
        public int CostID { get; set; }

        
        [DisplayName("File ID:")]
        public int FileID { get; set; }


    }
}
