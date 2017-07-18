using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class MerchantAccount
    {
        public int MerchantAccountId { get; set; }

        public int UserId { get; set; }

        public int LegalEntityId { get; set; }

        public string ACHResourceId { get; set; }

        public string Nickname { get; set; }

        public string AccountLast4 { get; set; }

        public decimal? PaymentCapAmount { get; set; }

        public BankAccountType AccountType { get; set; }

        public User User { get; set; }
    }

    public enum BankAccountType
    {
        Checking = 0,
        Savings = 1
    }

    public class DepositAccount
    {
        PaymentType paymentType;

        public DepositAccount(PaymentType paymentType)
        {
            this.paymentType = paymentType;
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public int LegalEntityId { get; set; }

        public string ACHResourceId { get; set; }        

        public string Nickname { get; set; }

        public string AccountLast4 { get; set; }

        public decimal? PaymentCapAmount { get; set; }

        public string AccountResourceId
        {
            get
            {
                switch (this.paymentType)
                {
                    case PaymentType.BankAccount:
                        return this.ACHResourceId;                    
                    case PaymentType.Manual:
                    default:
                        return string.Empty;
                }
            }
        }
    }
}
