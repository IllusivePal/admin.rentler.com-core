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
    
    public partial class FormProvider
    {
        public FormProvider()
        {
            this.Forms = new HashSet<Form>();
        }
    
        public long FormProviderId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficeCity { get; set; }
        public string OfficeState { get; set; }
        public string OfficeZip { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public System.DateTime UpdateDateUtc { get; set; }
    
        public virtual ICollection<Form> Forms { get; set; }
    }
}
