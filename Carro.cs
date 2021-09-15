using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Transactions;


namespace Exercicio_Carro
{
    class Carro
    {
        public string Nome {get; set;}
        public string Cor { get; set;}
        public string Modelo { get; set;}
        public double Preco { get; set;}

        public Carro()
        {
        }

        public void Andar(int kmPercorrido)
        {
            int i = 0;
            while (i <= kmPercorrido)
            {
                i++;
                Console.WriteLine("Percorrido " + (i + 99) + " Km!");
            }
        }
        public void RadarNaFrente(bool radar) 
        {

            if (!radar) //radar == false
            {
             Console.WriteLine("Tudo Ok! Pisa fundo Bino!!!");
                return;
            }
            Console.WriteLine("Radar a frente - reduzindo velocidade");
        }    

        public void Parar() 
        {
        Console.WriteLine(" O carro parou!");
        }

        public override string ToString()
        {
            return " Nome: "
                + this.Nome
                + " , Cor: "
                + this.Cor
                + " , Modelo:"
                + this.Modelo
                + " , Preço:R$ "
                + this.Preco;
        }

        public string AplicarDesconto(string cor)
        {
            if (cor == "branco" || cor == "preto")
            {
                this.Preco = this.CalcularDesconto(this.Preco);
                return this.ToString();
            }
             return ToString();
        }
        public double CalcularDesconto(double precoOriginal)
        {
            //return precoOriginal - (precoOriginal * 0.10);
            double precoReduzido = precoOriginal - (precoOriginal * 0.10);
            return precoReduzido;
        }
    }   
}

