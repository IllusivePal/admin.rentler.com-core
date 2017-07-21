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
    
    public partial class RentalApplicant
    {
        public RentalApplicant()
        {
            this.Screenings = new HashSet<Screening>();
        }
    
        public long RentalApplicantId { get; set; }
        public long RentalApplicationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.Guid> InviteKey { get; set; }
        public string ApplicationSnapshotId { get; set; }
        public int StatusCode { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
        public Nullable<System.DateTime> AgreeToTermsDateUtc { get; set; }
        public bool IsArchived { get; set; }
        public bool IsApplicationRequired { get; set; }
    
        public virtual RentalApplication RentalApplication { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
