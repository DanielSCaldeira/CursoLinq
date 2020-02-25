using CursoLinq.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LojaContext ef = new LojaContext())
            {
                var produtos = ef.Produtos.ToList();

                produtos.ForEach(x =>
                {
                    Console.WriteLine(x.Nome);
                });

                Produtos produto1 = produtos.First();
                Produtos produto2 = produtos.FirstOrDefault();
                //take pega a quantidade 
                var produto3 = produtos.Take(2).ToList();
                //skip pula 
                var produto4 = produtos.Skip(1).ToList();
                // ppula o primeiro e pega os 2 seguintes
                var produto5 = produtos.Skip(1).Take(2).ToList();

                var produto6 = produtos.Count();
                var produto7 = produtos.Count(x => x.Nome.Contains("a"));

                //Garante que só ira existir um registro
                var produto8 = produtos.Single();
                // Garante que só tenha um caso não tenha retorna null, se retorna mais de um gera exceção
                var produto10 = produtos.SingleOrDefault();

                //SkipWhile
                // Pula enquanto a condição é vedadeira ou seja ira trazer os produtos que são menores que 1000
                var produtos11 = produtos.SkipWhile(x => x.Valor > 1000).ToList();

                //Sum, Max, Min
                var produtos12 = produtos.Sum(x => x.Valor);
                var produtos13 = produtos.Max(x => x.Valor);
                var produtos14 = produtos.Min(x => x.Valor);

                //Union
                //Junta as listas com os dados diferentes e uni os iguais tornando um
                int[] vet1 = { 1, 2, 3, 4, 6, 9, 8 };
                int[] vet2 = { 11, 82, 93, 74, 14, 11, 10 };

                IEnumerable<int> union = vet1.Union(vet2);

                //Disttinct
                // retira da lista o dados que se repete
                int[] vet3 = { 1, 2, 3, 4, 6, 9, 9, 0, 8, 8 };
                var produtos15 = vet3.Distinct().ToList();

                //Any
                //verifica se existe
                var existe = produtos.Any();

            }

            Console.ReadKey();

        }
    }
}
