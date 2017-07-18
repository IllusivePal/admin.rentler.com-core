using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Transaction
    {
        public long TransactionId { get; set; }

        public int? PaymentSeriesId { get; set; }

        public int? TenantId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionDateUtc { get; set; }

        public TransactionStatus Status { get; set; }

        public string CommerceKey { get; set; }

        public PaymentType PaymentType { get; set; }

        public string StatusMessage { get; set; }

        public string Description { get; set; }

        public long? PaymentMethodId { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public decimal Fee { get; set;}

        public bool IsPending { get; set; }

        public string PendingReason { get; set; }

        public long? OriginalTransactionId { get; set; }

        public long? TransferId { get; set; }

        public Tenant Tenant { get; set; }

        public TransactionStatusDetail StatusDetail { get; set; }

        public bool? IsApproved { get; set; }

        public string PaymentTypeText
        {
            get
            {
                return this.PaymentType.Description();
            }
        }
    }

    public class TransactionStatusDetail
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public string DisplayMessage
        {
            get
            {
                StringBuilder builder = new StringBuilder(this.Name);

                if (!string.IsNullOrWhiteSpace(this.Message))
                {
                    builder.Append(" - ");
                    builder.Append(this.Message);
                }

                return builder.ToString();
            }
        }

        public void SetMessage(string message)
        {
            this.Message = ParseStatusMessage(message);
        }

        public static string ParseStatusMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return string.Empty;

            if (!message.Contains(';'))
                return message;

            string[] pairs = message.Split(';');

            if (pairs.Length == 0)
                return string.Empty;

            List<string> values = new List<string>();

            foreach (string p in pairs)
            {
                string value = GetPairValue(p);
                if (!string.IsNullOrWhiteSpace(value))
                    values.Add(value);
            }

            return string.Join(": ", values);
        }

        private static string GetPairValue(string pair)
        {
            if (!pair.Contains(':'))
                return pair.Trim();

            return pair.Replace("Message:", "").Trim();
        }
    }    

    public enum TransactionStatus
    {
        Pending = 0,
        Success = 1,
        Error = 2,
        Refund = 3,
        Return = 4
    }

    public enum PaymentType
    {
        [Description("Manual")]
        Manual = 0,

        [Description("Credit Card")]
        Credit,

        [Description("Debit Card")]
        Debit,

        [Description("Bank Account")]
        BankAccount,

        [Description("Cash")]
        Cash
    }

    public class TransactionDetail
    {
        public long TransactionId { get; set; }

        public int? PaymentSeriesId { get; set; }

        public int? TenantId { get; set; }

        public decimal Amount { get; set; }

        public decimal Fee { get; set; }

        public DateTime TransactionDateUtc { get; set; }

        public TransactionStatus Status { get; set; }

        public TransactionStatusDetail StatusDetail { get; set; }

        public string CommerceKey { get; set; }

        public PaymentType PaymentType { get; set; }

        public string StatusMessage { get; set; }

        public long? PaymentMethodId { get; set; }

        public DateTime CreateDateUtc { get; set; }

        public DateTime UpdateDateUtc { get; set; }

        public bool IsPending { get; set; }

        public string PendingReason { get; set; }

        public long? OriginalTransactionId { get; set; }

        public long? TransferId { get; set; }

        public int MonthlyDueDay { get; set; }

        public int GracePeriod { get; set; }

        public bool? IsApproved { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime LateDate
        {
            get
            {
                return this.DueDate.AddDays(this.GracePeriod + 1);
            }
        }

        public string PaymentTypeText
        {
            get
            {
                return this.PaymentType.Description();
            }
        }

        public decimal Total
        {
            get
            {
                return this.Amount + this.Fee;
            }
        }

        public Payer Tenant { get; set; }

        public Payee Landlord { get; set; }

        public List<ScheduledTransaction> ScheduledTransactions { get; set; }

        public Transaction OriginalTransaction { get; set; }
    }
}
