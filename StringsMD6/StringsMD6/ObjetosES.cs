using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMD6 {
    public class ObjetosES {
        public string Nome { get; set; }
        public  int  Idade{ get; set; }
        public ObjetosES(string nome, int idade) {

            Nome = nome;
            Idade = idade;
        }
        public override bool Equals(object obj) {

            ObjetosES outroObjeto = obj as ObjetosES;

            if (outroObjeto == null) {
                return false;
            }
            return 
                Nome == outroObjeto.Nome && 
                Idade == outroObjeto.Idade; 
        }

    }
}
