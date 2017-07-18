using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class VerificationError
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDateUtc { get; set; }
        public VerificationStep Step { get; set; }
        public int? UserId { get; set; }

        public IdVerifyError ToIdVerifyError()
        {
            IdVerifyError result = new IdVerifyError
            {
                Content = this.Content,
                CreateDateUtc = this.CreateDateUtc,
                Step = this.Step,
                UserId = this.UserId,
                Id = this._id.ToString()
            };

            string json;
            int index = this.Content.IndexOf('{');
            if (index != -1)
            {
                json = this.Content.Substring(index);
                result.JsonContent = json;

                // deserialize Json response
                try
                {
                    result.ExperianResponse = JsonSerializer.DeserializeFromString<ExperianResponse>(json);
                }
                catch (SerializationException e)
                {
                    result.SerializationException = "Unable to deserialize json response." + e.Message;
                }
            }
            return result;
        }
    }

    public enum VerificationStep
    {
        Verify = 1,
        VerifySubmit = 2,
        ReVerify = 3,
        ReVerifySubmit = 4,
        IsVerified = 5,
    }

    public class ExperianResponse
    {
        public bool Success { get; set; }

        public ExperianPreciseIDServer PreciseIDServer { get; set; }

        public ExperianError Error { get; set; }
    }

    public class ExperianError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ExperianFieldErrors FieldErrors { get; set; }
    }

    public class ExperianFieldErrors
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SSN { get; set; }

        public string CurrentAddress { get; set; }
    }
    public class ExperianPreciseIDServer
    {
        public ExperianKBAScore KBAScore { get; set; }

        public ExperianMessages Messages { get; set; }

        public ExperianPreciseIDServerError Error { get; set; }
    }

    public class ExperianMessages
    {
        public IEnumerable<ExperianConsumerStatement> ConsumerStatement { get; set; }
        public ExperianMessage Message { get; set; }
    }

    public class ExperianMessage
    {
        public string Number { get; set; }

        public string Text { get; set; }

        public string AddrMismatch { get; set; }
    }

    public class ExperianKBAScore
    {
        public ExperianGradedAnswer GradedAnswer { get; set; }
    }

    public class ExperianGradedAnswer
    {
        public IEnumerable<ExperianAnswerSet> AnswerSet { get; set; }
    }

    public class ExperianAnswerSet
    {
        public string QuestionType { get; set; }
        public string QuestionTypeDescription { get; set; }
        public string CreditTypeDescription { get; set; }
        public string AnswerResult { get; set; }
        public string QuestionWeight { get; set; }
    }

    public class ExperianPreciseIDServerError
    {
        public string ErrorCode { get; set; }

        public string ErrorDescription { get; set; }
    }

    public class ExperianConsumerStatement
    {
        public string Number { get; set; }
        public string Text { get; set; }
    }
}
