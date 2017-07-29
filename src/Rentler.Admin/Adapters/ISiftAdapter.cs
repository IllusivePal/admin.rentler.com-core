using Rentler.Admin.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Adapters
{
    public interface ISiftAdapter
    {
        Status<Common.Sift> GetScore(int userId);
        Status<Common.Sift> LabelUser(int userId, bool isBad);
    }

    public class SiftAdapter : ISiftAdapter
    {
        ICustomAuth _customAuth;
        public Status<Common.Sift> GetScore(int userId)
        {
            return null;

        }
        public Status<Common.Sift> LabelUser(int userId, bool isBad)
        {
            var testing = this._customAuth.GetIdentity();

            return null;
        }
    }
}
