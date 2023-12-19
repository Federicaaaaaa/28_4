using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_4
{
    internal class Documento
    {
        public string Scaffale { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public Stati Stato { get; set; }
        public List<Autore> Autori { get; set; }
    }
}
