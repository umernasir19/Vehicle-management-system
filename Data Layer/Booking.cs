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
    
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int VehicleID { get; set; }
        public int VehicleCategoryID { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int RateCardId { get; set; }
    
        public virtual VehicleCategory VehicleCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual VehiclesRateCard VehiclesRateCard { get; set; }
    }
}
