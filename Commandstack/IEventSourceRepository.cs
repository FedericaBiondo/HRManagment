using HRManagment.Commandstack;
using HRManagment.Commandstack.Model;

namespace Commandstack
{
        public interface IEventSourcedRepository<T> : IRepository<T>  
        where T : AggregateRoot
        {
            T GetById(Guid id, int version);
            T GetById(Guid id, DateTime pointInTime);

            T Add(T item, Dictionary<string, Dictionary<string, string>> alternateKeyValuePairs);
            T Update(T item, Dictionary<string, Dictionary<string, string>> alternateKeyValuePairs);
        }
    
}