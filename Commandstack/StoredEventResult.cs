using HRManagment.Common.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Commandstack
{
    public class StoredEventsResult
    {
        public StoredEventsResult(
            IEnumerable<IEvents> events,
            int aggregateRevision)           //IMemento<TKey> memento)
        {
            Events = events;
            AggregateRevision = aggregateRevision;
            //Memento = memento;
        }
        public IEnumerable<IEvents> Events { get; }

        public int AggregateRevision { get; }
        //public IMemento<TKey> Memento { get; }
    }
}
