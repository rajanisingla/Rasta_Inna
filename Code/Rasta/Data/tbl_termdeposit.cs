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
    
    public partial class tbl_termdeposit
    {
        public int TDID { get; set; }
        public Nullable<int> BankID { get; set; }
        public Nullable<int> TotalTime { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> DepositDate { get; set; }
        public string DepositType { get; set; }
    }
}
