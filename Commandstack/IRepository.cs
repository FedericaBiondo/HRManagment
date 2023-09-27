using HRManagment.Commandstack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Commandstack
{
        public interface IRepository<T> 
                         where T : AggregateRoot //interfaccia implementa T quando T fa parte di AggregateRoot
        {
            T GetById(Guid id);

            //void Save(T item);

            object Add(T item);
            //void AddBulk(ICollection<T> items);

            object Update(T item);
            object UpdateBulk(ICollection<T> item);

            object Delete(T item);
            object DeleteBulk(ICollection<T> item);

            //IEnumerable<T> Get(Func<T, bool> predicate);
        }
    
}
