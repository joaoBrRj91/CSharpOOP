using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Produto = new Produto();

            Console.WriteLine("Digite os dados do produto: ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Nome: ");
            Produto.Nome = Console.ReadLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine("Preço: ");
            Produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Quantidade em estoque: ");
            var quantidadeEmEstoque = Int32.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Produto.RealizarEntrada(quantidadeEmEstoque);
            Console.WriteLine(Produto);

            //Produto.RealizarSaida(quantidade: 21);
            //Produto.RealizarEntrada(quantidade: 15);


            Console.ReadKey();

        }
    }
}
