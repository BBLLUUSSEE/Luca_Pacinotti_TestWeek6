using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week6.Core.Entities
{
    [DataContract]
    public class Ordine
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime DataOrdine { get; set; }
        [DataMember]
        public string CodiceOrdine { get; set; }
        [DataMember]
        public string CodiceProdotto { get; set; }
        [DataMember]
        public decimal Importo { get; set;  }
    }
}
