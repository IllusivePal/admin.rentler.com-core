using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Rentler.Admin.Adapters;
using System.Security.Claims;

namespace Rentler.Admin.Auth
{
    public interface ICustomAuth
    {
        Identity GetIdentity();
    }
    public class CustomAuthentication: ICustomAuth
    {
        IHttpContextAccessor _httpaccessor;
        public CustomAuthentication(IHttpContextAccessor accessor)
        {
            this._httpaccessor = accessor;
        }

        public Identity GetIdentity()
        {
            var identity = this._httpaccessor.HttpContext.User.Identity;
            if (!identity.IsAuthenticated)
                return new Identity();

            var userInfo = identity as ClaimsIdentity;
            var UserId = userInfo.FindFirst("sub").Value;
            var username = userInfo.FindFirst("given_name").Value;

            return new Identity(int.Parse(UserId), username);

        }
    }
}
