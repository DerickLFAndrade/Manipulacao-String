using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMD6 {
    internal class Program {
        static void Main() {
            ExtratorValorArgumentos url = new ExtratorValorArgumentos(null);
            string urll = "pagina?argumentos";

           string arg = urll.Substring(6);
            int indice = urll.IndexOf('?');
           Console.WriteLine(indice);
        }
    }
}
