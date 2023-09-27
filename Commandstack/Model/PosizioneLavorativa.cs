using HrManagment.Contract.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Commandstack.Model
{
    public class PosizioneLavorativa : AggregateRoot
    {
        public string Ruolo { get; private set; }
        public string Sede { get; private set; }
        internal IEnumerable<string> Requisiti { get; private set; }
        public DateOnly DataDiApertura { get; private set; }
        public DateOnly DataDiChiusura { get; private set; }




        public PosizioneLavorativa(string ruolo, string sede,IEnumerable<string> requisiti,DateOnly? dataDiApertura,DateOnly? dataDiChiusura) : base()
        {
            if (ruolo is null)
            {
                throw new ArgumentNullException(nameof(ruolo));
            }

            if (sede is null)
            {
                throw new ArgumentNullException(nameof(sede));
            }

            if (dataDiApertura is null)
            {
                throw new ArgumentNullException(nameof(dataDiApertura));
            }

            if (dataDiChiusura is null)
            {
                throw new ArgumentNullException(nameof(dataDiChiusura));
            }

            RaiseEvent(new PosizioneLavorativaCreateEvents(this.Id, ruolo, sede, requisiti, dataDiApertura, dataDiChiusura));
        }

        public void Apply(PosizioneLavorativaCreateEvents @event)
        
        {
            Ruolo = @event.Ruolo;
            Sede = @event.Sede;
            Requisiti = @event.Requisiti;
           
        }


    }
}

