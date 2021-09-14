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

        public Carro()
        {
        }

     private static string  kmPercorrido;

        public void Andar(int kmPercorrido) {
            int i = 0;
            while (i <= kmPercorrido){
                Console.WriteLine("Percorrido " + (kmPercorrido + 100) + " Km!");
                i++;
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
                double calculoDesconto = this.Preco * 0.10;
                double precoComDesconto = this.Preco - calculoDesconto;
                this.Preco = precoComDesconto;
                return this.ToString();
            }
            else
            {
             return ToString();
            }
        }
                
    }
}

