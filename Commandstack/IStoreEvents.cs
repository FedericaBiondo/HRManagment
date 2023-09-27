using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Commandstack
{
    internal class IStoreEvents
    {
        public interface IStoreEvent
        {
            StoreEventsResult GetById(Guid id, string bucket = null);
            StoredEventsResult GetById(Guid id, int version, string bucket = null);
            StoredEventsResult GetById(Guid id, int minVersion, int maxVersion, string bucket = null);
            StoredEventsResult GetById(Guid id, DateTime pointInTime, string bucket = null);
            //StoredEventsResult GetByMemento(IMemento memento, int maxRevision, string bucketId);
            //bool AddSnapshot(IMemento memento, string bucketId);
            //IMemento GetMemento(Guid id, int maxRevision, string bucketId);
            void Save(IEvents @event, string bucket);

            void Save(ICollection<IEvents> events, string bucket);
        }

    }
}
