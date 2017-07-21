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
    
    public partial class ScheduledTransaction
    {
        public long ScheduledTransactionId { get; set; }
        public int PaymentSeriesId { get; set; }
        public int TenantId { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime TransactionDateUtc { get; set; }
        public int StatusCode { get; set; }
        public int PaymentTypeCode { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
        public long PaymentMethodId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> TransactionId { get; set; }
        public Nullable<int> PaymentId { get; set; }
        public Nullable<long> AutopaySettingId { get; set; }
        public Nullable<bool> IsApproved { get; set; }
    
        public virtual Payment Payment { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual PaymentSeries PaymentSeries { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual AutopaySetting AutopaySetting { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
