//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sampleEco.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_shippingDetails
    {
        public int shippingDetailsId { get; set; }
        public Nullable<int> memberId { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string Zipcode { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public string paymentyype { get; set; }
    
        public virtual tbl_members tbl_members { get; set; }
    }
}
