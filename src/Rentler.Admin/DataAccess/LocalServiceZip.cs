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
    
    public partial class LocalServiceZip
    {
        public long LocalServiceZipId { get; set; }
        public long LocalServiceId { get; set; }
        public string Zip { get; set; }
    
        public virtual LocalService LocalService { get; set; }
    }
}
