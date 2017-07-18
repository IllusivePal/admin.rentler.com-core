using Rentler.Admin.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Utility
    {
        public string UtilityId { get; set; }

        public UtilityCode UtilityCode { get; set; }

        public string Name
        {
            get
            {
               // if (!string.IsNullOrEmpty(this.UtilityId) &&
                   // Utilities.Current.All.ContainsKey(this.UtilityId))
                  //  return Utilities.Current.All[this.UtilityId];
                return string.Empty;
            }
        }
    }

    public enum UtilityCode
    {
        [Description("N/A")]
        None = 0,

        [Description("Landlord")]
        Landlord = 1,

        [Description("Tenant")]
        Tenant = 2
    }
}
