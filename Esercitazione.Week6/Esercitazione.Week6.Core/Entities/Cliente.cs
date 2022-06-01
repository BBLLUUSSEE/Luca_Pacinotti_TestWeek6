using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week6.Core.Entities
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CodiceCliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }
    }
}
