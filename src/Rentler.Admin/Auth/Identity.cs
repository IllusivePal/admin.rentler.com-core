using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Auth
{
    public class Identity
    {
        public Identity()
        {
            this.Username = string.Empty;
        }

        public Identity(int userId, string username)
        {
            this.IsAuthenticated = true;
            this.UserID = userId;
            this.Username = username;
        }

        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public int UserID { get; set; }
    }
}
