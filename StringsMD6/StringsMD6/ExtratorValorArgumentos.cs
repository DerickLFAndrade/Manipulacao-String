using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsMD6 {
    public class ExtratorValorArgumentos {

        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorArgumentos(string url) {

            if(string.IsNullOrEmpty(url)) {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = URL.Substring(indiceInterrogacao);

            URL = url;
        }
        public string GetValor(string nomeParametro) {

            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1) {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

        }

        public Match GetNumero (string numero) {
            Match verificar = Regex.Match(numero, "[0-9] [0-9] [0-0] [-] [0-9] [0-9] [0-0]");
            return verificar;
        }

    }
}
