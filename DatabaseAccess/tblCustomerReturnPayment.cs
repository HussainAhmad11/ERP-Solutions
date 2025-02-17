//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomerReturnPayment
    {
        public int CustomerReturnPaymentID { get; set; }
        public int CustomerReturnInvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int CustomerInvoiceID { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public string InvoiceNo { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double RemainingBalance { get; set; }
        public int UserID { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }

        public virtual tblBranch tblBranch { get; set; }
        public virtual tblCompany tblCompany { get; set; }
        public virtual tblCustomer tblCustomer { get; set; }
        public virtual tblCustomerInvoice tblCustomerInvoice { get; set; }
        public virtual tblCustomerReturnInvoice tblCustomerReturnInvoice { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
