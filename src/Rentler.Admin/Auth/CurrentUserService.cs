using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Auth
{
    public class CurrentUserService
    {
        private IHttpContextAccessor _contextAccessor;
        private HttpContext _context { get { return _contextAccessor.HttpContext; } }

        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public string UserName
        {
            get
            {
                var userName = "SystemGenerated";
                if (_context.User != null)
                {
                    var identity = _context.User.Identity;
                    if (identity != null && identity.IsAuthenticated)
                    {
                        userName = identity.Name;
                    }
                }

                return userName;
            }

        }
    }
}
