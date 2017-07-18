using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    [ProtoContract]
    public class BusinessDay
    {
        [ProtoMember(1)]
        public DayOfWeek DayOfWeek { get; set; }

        [ProtoMember(2)]
        public bool IsClosed { get; set; }

        [ProtoMember(3)]
        public BusinessHours Hours1 { get; set; }

        [ProtoMember(4)]
        public BusinessHours Hours2 { get; set; }

        public static BusinessDay Default(DayOfWeek dayOfWeek)
        {
            BusinessDay businessDay = new BusinessDay()
            {
                DayOfWeek = dayOfWeek,
                IsClosed = false,
                Hours1 = new BusinessHours(),
                Hours2 = new BusinessHours()
            };

            return businessDay;
        }
    }

    [ProtoContract]
    public class BusinessHours
    {
        public BusinessHours() { }

        public BusinessHours(TimeSpan? open, TimeSpan? close)
        {
            this.OpenTime = open;
            this.CloseTime = close;
        }

        [ProtoMember(1)]
        public TimeSpan? OpenTime { get; set; }

        [ProtoMember(2)]
        public TimeSpan? CloseTime { get; set; }
    }
}
