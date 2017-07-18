using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Payer
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool IsScammer { get; set; }

        public string UserResourceId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Sift Sift { get; set; }
    }
}
