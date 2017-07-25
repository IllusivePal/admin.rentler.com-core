using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Telephony
{
    public interface IPhoneService
    {
        bool DeletePhoneNumber(string phoneId, string phoneNumber);

        void UpdateNumber(string phoneId, long buildingId);

        string GenerateNumber(ref string phoneId, string areaCode = null,
            string regionCode = null, string countryCode = "US");

        bool DeleteRecordingCalls(string phoneNumber);
    }

    /*public class PhoneService:IPhoneService
    {
        string accountSid;
        string authToken;
        string twilioBaseUrl;
        string telephonyBaseUrl;

        public PhoneService()
        {
            accountSid = Configuration.TwilioAccountId;
            authToken = Configuration.TwilioAuthToken;
            twilioBaseUrl = Configuration.TwilioBaseUrl;
            telephonyBaseUrl = Configuration.TelephonyBaseUrl;
        }
    }*/
}
