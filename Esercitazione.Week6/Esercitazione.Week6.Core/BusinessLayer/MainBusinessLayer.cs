using Esercitazione.Week6.Core.Entities;
using Esercitazione.Week6.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week6.Core.BusinessLayer
{
    public class MainBusinessLayer : IOrdersBL
    {
        private readonly IOrdineRepository ordineRepo;

        public MainBusinessLayer()
        {
            this.ordineRepo = DependencyContainer.Resolve<IOrdineRepository>();
        }

        public bool CreaOrdine(Ordine nuovoOrdine)
        {
            if (nuovoOrdine == null)
                return false;

            return ordineRepo.Add(nuovoOrdine);
        }
        public bool ModificaOrdine(Ordine modificaOrdine)
        {
            if (modificaOrdine == null)
                return false;

            return ordineRepo.Update(modificaOrdine);
        }

        public Ordine CercaPerId(int idordine)
        {
            if (idordine <= 0)
                return null;

            return ordineRepo.GetById(idordine);
        }

        public bool EliminaOrdine(int idordine)
        {
            if (idordine <= 0)
                return false;

            Ordine ordineDaEliminare = this.ordineRepo.GetById(idordine);

            if (ordineDaEliminare != null)
                return ordineRepo.Delete(ordineDaEliminare);

            return false;
        }









        public bool CreaCliente(Cliente nuovoCliente)
        {
            if (nuovoCliente == null)
                return false;

            return ordineRepo.Add(nuovoCliente);
        }

        public bool ModificaCLiente(Cliente modificaCliente)
        {
            if (modificaCliente == null)
                return false;

            return ordineRepo.Update(modificaCliente);
        }
        public bool EliminaCliente(Cliente eliminaCliente)
        {
            if (eliminaCliente == null)
                return false;

            return ordineRepo.Delete(eliminaCliente);
        }
    }
}
