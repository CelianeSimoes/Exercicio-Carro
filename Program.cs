using System;
using System.Globalization;

namespace Exercicio_Carro
{
    class Program
    {
        static void Main()
        {
            Carro carro = new Carro();
            

            Console.WriteLine("Por gentileza insira os dados do veiculo");
            Console.Write("Nome: ");
            carro.Nome = Console.ReadLine();

            Console.Write("Cor: ");
            carro.Cor = Console.ReadLine();

            Console.Write("Modelo: ");
            carro.Modelo = Console.ReadLine();

            Console.Write("Preço: ");
            carro.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("A cada quilometro percorrido imprimir o resultado:");
            carro.Andar(int.Parse(Console.ReadLine()));

            Console.Write("Informe se há radar a frente:");
            carro.RadarNaFrente(Console.ReadLine());

            Console.Write("Test Drive finalizado: ");
            carro.Parar(Console.ReadLine());

            Console.WriteLine ("Descrição para comprador: " + carro.AplicarDesconto(carro.Cor));
          


            



        }
    }
}
