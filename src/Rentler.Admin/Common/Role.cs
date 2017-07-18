using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Role
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public PagedList<Common.User> UsersInRole { get; set; }
    }
}
