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
    
    public partial class RefreshSchedule
    {
        public long RefreshScheduleId { get; set; }
        public long BuildingId { get; set; }
        public System.DateTime ScheduledDateUtc { get; set; }
    
        public virtual Building Building { get; set; }
    }
}
