using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            // ARRAY LIST
            ArrayList Lista = new ArrayList(); // aceita qualquer tipo de objeto
            Lista.Add("First Item"); // Adiciona um item a lista
            Lista.Remove("First Item"); //Remove um item da lista, *ele testa se tem o item ou nao
            Lista.RemoveAt(0); // Remove um item passando por parametro o Index
            Lista.Sort(); // Ordena a lista        
            Lista.Clear(); // Limpa a Lista
            Lista.Contains("First Item"); // Procura o item do parametro e retorna valor bool
            int qtd = Lista.Count; // retorna quantidade de itens na lista em inteiro 

            //LIST                  Tem que especifica o tipo
            List<int> ListaDeInteiros = new List<int>();
            ListaDeInteiros.Add(54);
            ListaDeInteiros.Add(75);
            ListaDeInteiros.Add(60);
            ListaDeInteiros.Add(80);

            //Manipulação de lista
            foreach (var l in ListaDeInteiros) // i recebe objeto colocado no index de 0 até ListaDeInteiros.Count
            {
                Console.WriteLine("Item na posição de 0 ao fim da lista: "+ l);
            }


            //DICTONARY
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(542, "Felipe");
            dict.Add(545, "Felipsfase");
            dict.Add(552, "Feasfsaflipsaffe");
            dict.Add(598, "Igor");
            dict.Remove(598); // passa a chave que foi definida nos dict.add
            dict.ContainsKey(2); // procura pela chave que foi passada por parametro
            dict.ContainsValue("Pedro"); // procura pelo valor que foi passado por parametro
            var x =dict.Values; // retorna todos valores do Dictionary para uma nova lista

            foreach(var d in dict)
            {
                d.Value.Any(); // Rretorna se tem algo no Dictionary ou na Lista
                d.Value.Count(); // retorna a quantidade de itens que tem no Dictionary ou na Lista
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }
                

            }
        }
    }
}
