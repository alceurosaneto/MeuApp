using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Notebook", 3000.00);
            Produto p2 = new Produto(2, "Mouse", 80.00);

            Console.WriteLine($"Produto: {p1.Name}, Preço: {p1.Price}");
            Console.WriteLine($"Produto: {p2.Name}, Preço: {p2.Price}");

            double dolar = 5.20;
            Console.WriteLine($"Preço do {p1.Name} em dólar: {p1.PriceInDolar(dolar)}");
            Console.WriteLine($"Preço do {p2.Name} em dólar: {p2.PriceInDolar(dolar)}");

        }
    }

    struct Produto
    {
        public Produto(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }


}


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
