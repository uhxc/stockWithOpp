using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockWithOpp
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public override string ToString()
        {
            return $"Dados do produto: {Name}, {Price:f2}, {Quantity} unidades, total: {ValorEmEstoque():f2}";
        }

        public double ValorEmEstoque()
        {
            return Price * Quantity;
        }
        public void AdicionarProduto()
        {
            Console.WriteLine("digite a quantade a ser adicionada em estoque");
            int a = int.Parse(Console.ReadLine());
            Quantity += a;
        }
        public void RemoverProduto()
        {
            Console.WriteLine("digite a quantade a ser removida de estoque");
            int b = int.Parse(Console.ReadLine());
            Quantity -= b;
        }

    }
}
