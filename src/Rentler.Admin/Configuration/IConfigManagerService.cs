using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Admin.Configuration
{
    public interface IConfigManagerService
    {
        AppSettings App { get; }
    }
}
