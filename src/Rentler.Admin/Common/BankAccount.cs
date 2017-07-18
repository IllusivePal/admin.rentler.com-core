using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public int UserId { get; set; }

        public int TypeCode { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string RoutingNumber { get; set; }

        public string Nickname { get; set; }

        public User User { get; set; }

        public List<AchTransaction> AchTransactions { get; set; }
    }
}
