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
    
    public partial class Applicant
    {
        public long ApplicantId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int StatusCode { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual User User { get; set; }
    }
}
