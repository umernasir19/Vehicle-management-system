//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int CustomerTypeID { get; set; }
        public string Gender { get; set; }
        public System.DateTime DoB { get; set; }
        public decimal CNICNumber { get; set; }
        public decimal LicenseNumber { get; set; }
        public bool IsCar { get; set; }
        public bool IsBike { get; set; }
        public decimal PrimarycontactNumber { get; set; }
        public Nullable<decimal> SecondaryContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Remarks { get; set; }
        public string RefrenceId { get; set; }
    
        public virtual Customer_Type Customer_Type { get; set; }
    }
}