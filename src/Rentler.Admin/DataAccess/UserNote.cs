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
    
    public partial class UserNote
    {
        public int UserNoteId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
    
        public virtual User User { get; set; }
    }
}
