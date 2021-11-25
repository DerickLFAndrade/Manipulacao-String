using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMD6 {
    public class ExtratorValorArgumentos {
        public string URL { get; }
        public ExtratorValorArgumentos(string url) {

            string.IsNullOrEmpty(url);

            if (url == null) {
                throw new ArgumentNullException(nameof(url));
            }
            if (url == "") {
                throw new ArgumentException("O argumento não pode ser uma string vazia: ",nameof(url));
            }
            URL = url;
        }

    }
}
