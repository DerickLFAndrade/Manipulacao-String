using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsMD6 {
    internal class Program {
        static void Main() {
          //  ExtratorValorArgumentos url = new ExtratorValorArgumentos(null);
          //  string urll = "pagina?argumentos";
            string numero = "5454-124";
            //ExtratorValorArgumentos ext = new ExtratorValorArgumentos("aaaa");
            //string padrao = "[0-9][0-9][0-9][-][0-9][0-9][0-9]";
            string padrao2 = "[0-9]{3,4}[-]{0,1}[0-9]{3}";
            Match resultado = Regex.Match(numero, padrao2);
            Console.WriteLine(resultado.Value);
           // Console.WriteLine(urll.StartsWith("pagina?argumentos"));
           //string arg = urll.Substring(6);
           // int indice = urll.IndexOf('?');
           //Console.WriteLine(indice);
        }
    }
}
