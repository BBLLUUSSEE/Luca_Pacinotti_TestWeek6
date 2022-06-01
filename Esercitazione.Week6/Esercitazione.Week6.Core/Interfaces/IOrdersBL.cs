using Esercitazione.Week6.Core.Entities;
using Esercitazione.Week6.Core.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week6.Core.Interfaces
{
    public interface IOrdersBL
    {
        bool CreaOrdine(Ordine nuovoOrdine);
        bool ModificaOrdine(Ordine ModificaOrdine);
        bool ModificaCliene(Cliente nuovoCliente);
        bool Add(Ordine nuovoOrdine);
        bool Update(Ordine modificaOrdine);
        bool Delete(Ordine eliminaOrdine);
        bool Add(Cliente nuovoCliente);
        bool Update(Cliente modificaCliente);
        bool Delete(Cliente eliminaCliente);
    }
}
