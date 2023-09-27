using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Common.Exceptions
{
    [Serializable]
    public class MissingApplyMethodForEventInAggregateException : Exception
    {
        public MissingApplyMethodForEventInAggregateException(Type eventType, Type aggregateType)
        {
            EventType = eventType;
            AggregateType = aggregateType;
        }
        public MissingApplyMethodForEventInAggregateException(Type eventType, Type aggregateType, string message) : base(message)
        {
            EventType = eventType;
            AggregateType = aggregateType;
        }
        public MissingApplyMethodForEventInAggregateException(Type eventType, Type aggregateType, string message, Exception inner) : base(message, inner)
        {
            EventType = eventType;
            AggregateType = aggregateType;
        }
        protected MissingApplyMethodForEventInAggregateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public Type EventType { get; }
        public Type AggregateType { get; }
    }
}
