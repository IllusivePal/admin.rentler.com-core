//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentler.Admin.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lease
    {
        public Lease()
        {
            this.Tenants = new HashSet<Tenant>();
            this.PaymentSeries = new HashSet<PaymentSeries>();
        }
    
        public int LeaseId { get; set; }
        public long PropertyId { get; set; }
        public string Unit { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public Nullable<System.DateTime> EndDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual ICollection<Tenant> Tenants { get; set; }
        public virtual ICollection<PaymentSeries> PaymentSeries { get; set; }
    }
}
