using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Esercitazione.Week6.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        IOrdersBL ordersBL;

        public Service1()
        {
            // Configurazione DI
            DependencyContainer.Register<ordersBL, MainBusinessLayer>();
            //DependencyContainer.Register<IBookRepository, EFBookRepository>();

            // Risoluzione
            this.ordersBL = DependencyContainer.Resolve<ordersBL>();

        }

        public bool CreaOrdine(Ordine nuovoOrdine)
        {
            if (nuovoOrdine == null)
                return false;

            return this.ordersBL.CreaOrdine(nuovoOrdine);
        }
        public bool ModificaOrdine(Ordine modificaORdine)
        {
            if (modificaORdine == null)
                return false;

            return this.ordersBL.ModificaOrdine(modificaORdine);
        }

        public bool EliminaOrdine(int IdOrdine)
        {
            if (IdOrdine > 0)
                return this.ordersBL.EliminaOrdine(IdOrdine);

            return false;
        }
    }
}
