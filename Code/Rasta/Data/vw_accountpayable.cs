//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rasta.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_accountpayable
    {
        public int APID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
        public Nullable<System.DateTime> PaymentDueDate { get; set; }
        public Nullable<int> CostCodeID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<int> SiteID { get; set; }
        public string PaymentPurpose { get; set; }
        public string PONumber { get; set; }
        public string POAmount { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> RecievedDate { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<int> IsApproved { get; set; }
        public Nullable<int> IsPaid { get; set; }
        public Nullable<int> IsForecast { get; set; }
    }
}
