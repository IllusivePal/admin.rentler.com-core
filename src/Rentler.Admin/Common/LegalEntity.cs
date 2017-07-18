using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class LegalEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceUrl { get; set; }
        public string RentMoolaResourceId { get; set; }
        public string RentMoolaResourceUrl { get; set; }
        public string SSNLast4 { get; set; }
        public string Phone { get; set; }
        public LegalEntityStatus Status { get; set; }
        public UserPreview User { get; set; }
    }

    public enum LegalEntityStatus
    {
        Approved,
        Declined,
        Pending,
        Duplicate
    }

    public class LegalEntityDetail : LegalEntity
    {
        public string GroupName { get; set; }

        public string CompanyType { get; set; }

        public string BusinessName { get; set; }

        public string CorporateName { get; set; }

        public string YearEstablished { get; set; }

        public string TaxNumber { get; set; }

        public string Units { get; set; }

        public string AnnualSalesVolume { get; set; }

        public string AveragePayment { get; set; }

        public string PrincipalFirstName { get; set; }

        public string PrincipalLastName { get; set; }

        public DateTime PrincipalDob { get; set; }

        public string PrincipalTitle { get; set; }

        public string PrincipalPhone { get; set; }

        public string PrincipalEmail { get; set; }

        public string PrincipalDriversLicense { get; set; }

        public string PrincipalDriversLicenseState { get; set; }

        public string PrincipalSSN { get; set; }

        public DateTime TosAcceptanceDate { get; set; }

        public string TosAcceptanceIp { get; set; }

        public LegalEntityAddress BusinessAddress { get; set; }
    }

    public enum CompanyType
    {
        CORPORATION = 0,
        PARTNERSHIP = 1,
        SOLE_PROPRIETOR = 2,
        LTD_COMPANY = 3,
        LLC_COMPANY = 4,
        PLC_COMPANY = 5,
        LLP_PARTNERSHIP = 6,
        NON_PROFIT = 7,
        TRUST = 8,
        TAX_EXEMPT_ORG = 9,
        INTERNATIONAL_ORG = 10,
        GOVERNMENT_AGENCY = 11
    }

    public class LegalEntityAddress
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }
    }
}
