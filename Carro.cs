using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Transactions;


namespace Exercicio_Carro
{
    class Carro
    {

        public string Nome;
        public string Cor;
        public string Modelo;
        public double Preco;
        public double valorComDesconto;
        public double valorDoDesconto;
        public string retornoMetodoToString;


        public Carro(string nome, string cor, string modelo, double preco)
        {
            Nome = nome;
            Cor = cor;
            Modelo = modelo;
            Preco = preco;
        }

        public Carro()
        {
        }

        public void Andar(int kmAPercorrer)
        {
            for (int i = 0; i <= kmAPercorrer; i ++)
            {
                Console.WriteLine("Percorrido " + ( i + 100) + " Km!");
            }
        }

        public void RadarNaFrente(string radar)
        {
            if (radar == "sim")
            {
                Console.WriteLine("Radar a frente - reduzindo velocidade");
            }
            else
            {
                Console.WriteLine("Tudo Ok! Pisa fundo Bino!!!");
            }
        }

        public void Parar(string testeFinalizado)
        {
            if(testeFinalizado == "sim"){
                Console.WriteLine(" O carro parou!");
            }
        }

        public override string ToString()
        {
            return " Nome: "
                + Nome
                + " , Cor: "
                + Cor
                + " , Modelo:"
                + Modelo
                + " , Preço:R$ "
                + this.Preco;
        }

        public string AplicarDesconto(string cor)
        {
            if (cor == "branco" || cor == "preto")
            {
                double valorDoDesconto = this.Preco * 0.10;
                double valorComDesconto = this.Preco - valorDoDesconto;
                this.Preco = valorComDesconto;
                return this.ToString();
            }
            else
            {
                var retornoMetodoToString = ToString();
                return retornoMetodoToString;
            }
        }
                
    }
}

