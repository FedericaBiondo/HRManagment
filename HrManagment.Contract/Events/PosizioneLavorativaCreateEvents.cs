using HRManagment.Common.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HrManagment.Contract.Events
{
    public class PosizioneLavorativaCreateEvents : Event
    {

        public PosizioneLavorativaCreateEvents
        (
            Guid idPosizioneLavorativa, 
            string ruolo,
            string sede,
            IEnumerable<string> requisiti,
            DateOnly? dataDiApertura,
            DateOnly? dataDiChiusura)
        {
            idPosizioneLavorativa = idPosizioneLavorativa;
            Ruolo = ruolo;
            Sede = sede;
            Requisiti = requisiti;
           
        }

        public Guid idPosizioneLavorativa { get; private set; }
        public string Ruolo { get; private set; }
        public string Sede { get; private set; }
        public IEnumerable<string> Requisiti { get; private set; }
       
    }
}
