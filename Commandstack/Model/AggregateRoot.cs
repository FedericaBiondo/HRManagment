
using HRManagment.Common.Events;
using HRManagment.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Commandstack.Model
{
    public abstract class AggregateRoot // Aggrgata = radice
    {
        public Guid Id { get; private set; } // guid proprietà che si incrementa in automatico
        public int Version { get; private set; } 

        public IList<IEvents> UnpublishedEvents { get; private set; }
        public IList<IEvents> UncommittedEvents { get; private set; }
        

        public AggregateRoot() //costruttore
        {
            Id = Guid.NewGuid();
        }
        protected void RaiseEvent(IEvents @event, bool shouldPublish = true)  // metodo che pubblica e salva eventi
        {
            if (shouldPublish)
                this.UnpublishedEvents.Add(@event);
            this.UncommittedEvents.Add(@event);
            this.Version++;
            ApplyLookup(@event); // serializzazione permette data una classe di tarsmetterla da un servizio a un altro. dato un dto di un api, la respons che riceviamo all interno del body, il json che risponde è un formato per la serializzazione. 
        }

        protected virtual void ApplyLookup(IEvents @event) // applica l'evento che ha precedentemente salvato e pubblicato, va a creare un nuovo oggetto 
        {
            var applyMethod = this.GetType().GetMethods().FirstOrDefault(m => m.Name == "Apply" && m.GetParameters().FirstOrDefault(p => p.ParameterType == @event.GetType()) != null);
            if (applyMethod != null) // se non è null devo applicare qualcosa e faccio Invoke, applico un evento. 
                applyMethod.Invoke(this, new object[] { @event });
            else
                throw new MissingApplyMethodForEventInAggregateException(@event.GetType(), this.GetType()); //se è null viene chiamato l'altra classe della cartella Exceptions
        }

    }
}
