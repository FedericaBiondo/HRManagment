using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Common.Events
{
    public class Event : IEvents
    {
        public Guid id { get; private set; }
        public DateTime RaiseTimeUtc { get; private set; } // utc  perché se uso un tempo già in local time avrei il problema dell'ora legale e nella conversione dell'orario potrei non capirmi con chi ho dall'altra parte. Se li tratto come utc sono sicuro che i danni saranno limitati, e il datetime si aggiornerà da solo. 


        public Event()
        {
            id = Guid.NewGuid();
            RaiseTimeUtc = DateTime.UtcNow;
        }
    }

    } 
