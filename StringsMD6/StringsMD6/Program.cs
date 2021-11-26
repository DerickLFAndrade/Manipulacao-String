using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsMD6 {
    internal class Program {
        static void Main() {
            //ManipulacaoStrings();

            ClasseObject();
            Console.ReadKey();
        }
        public static void ClasseObject() {
            ObjetosES obj_1 = new ObjetosES("Derick", 23);
            ObjetosES obj_2 = new ObjetosES("Derick", 23);

            if(obj_1.Equals(obj_2) == true) {
                Console.WriteLine($"O objeto é igual ao objeto 2");
            } else {
                Console.WriteLine($"O objeto não é igual ao objeto 2");
            }
           

        }
        public static void ManipulacaoStrings() {
            string urlParametros = "http://www.bytebank.com/cabio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorArgumentos extratorDeValores = new ExtratorValorArgumentos(urlParametros);

            string valorOrig = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine($"Valor de moedaOrigem: {valorOrig}");

            string valorDest = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine($"Valor de moedaDestino: {valorDest}");

            string valor = extratorDeValores.GetValor("VaLor");
            Console.WriteLine($"Valor: {valor}");
        }
    }
}


//string testeRemocao = "primeiraParte&ParteRemover";
//int indiceEcomercial = testeRemocao.IndexOf('&');
//Console.WriteLine(testeRemocao.Remove(indiceEcomercial));



// string numero = "5454-124";
//string padrao = "[0-9][0-9][0-9][-][0-9][0-9][0-9]";
// string padrao2 = "[0-9]{3,4}-?[0-9]{3}";
//  Match resultado = Regex.Match(numero, padrao2);
// Console.WriteLine(resultado.Value);



//string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
//string nomeArg = "moedaDestino=";


//int indice = palavra.IndexOf(nomeArg);
//Console.WriteLine("Indice da palavra " + indice);


//Console.WriteLine(palavra);
//Console.WriteLine(palavra.Substring(indice));
//Console.WriteLine("Tamanho da string nome do argumento " + nomeArg.Length);
//Console.WriteLine(palavra.Substring(indice + nomeArg.Length));