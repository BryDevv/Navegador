using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador
{
    internal class Historial
    {
        string url;
        int contador;
        DateTime date;

        public string Url { get => url; set => url = value; }
        public int Contador { get => contador; set => contador = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
