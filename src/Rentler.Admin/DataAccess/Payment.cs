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
    
    public partial class Payment
    {
        public Payment()
        {
            this.PaymentLineItems = new HashSet<PaymentLineItem>();
            this.ScheduledTransactions = new HashSet<ScheduledTransaction>();
        }
    
        public int PaymentId { get; set; }
        public int PaymentSeriesId { get; set; }
        public System.DateTime DueDateUtc { get; set; }
        public int StatusCode { get; set; }
        public bool IsProrated { get; set; }
        public bool IsPaymentReminderSent { get; set; }
        public bool IsPastDueReminderSent { get; set; }
    
        public virtual ICollection<PaymentLineItem> PaymentLineItems { get; set; }
        public virtual ICollection<ScheduledTransaction> ScheduledTransactions { get; set; }
        public virtual PaymentSeries PaymentSeries { get; set; }
    }
}
