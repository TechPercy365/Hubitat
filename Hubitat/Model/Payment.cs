//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hubitat.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public string paymentID { get; set; }
        public string rentID { get; set; }
        public string payMethod { get; set; }
        public decimal payAmount { get; set; }
        public decimal payTotalPay { get; set; }
        public decimal payChange { get; set; }
        public System.DateTime payDate { get; set; }
    
        public virtual Rent Rent { get; set; }
    }
}
