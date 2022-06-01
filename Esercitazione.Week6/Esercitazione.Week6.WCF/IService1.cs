using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Esercitazione.Week6.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        bool CreaOrdine(Ordine nuovoOrdine);

        [OperationContract]
        bool ModificaOrdine(Ordine modificaOrdine);

        [OperationContract]
        bool EliminaOrdine(int idOrdine);
    }
}
