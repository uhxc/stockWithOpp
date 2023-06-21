namespace stockWithOpp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Tv = new Product();
            Console.WriteLine("escreva o nome do produto");
            Tv.Name = Console.ReadLine();
            Console.WriteLine("escreva o preco do produto");
            Tv.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("escreva a quantidade do produto");
            Tv.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(Tv);
            
            
            Tv.AdicionarProduto();
            Console.WriteLine(Tv);

            
            Tv.RemoverProduto();
            Console.WriteLine(Tv);
        }
    }
}