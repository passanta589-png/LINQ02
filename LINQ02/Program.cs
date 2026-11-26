using LINQ02.DataSources;

namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q01
            var top3EX = Source.ProductList
               .OrderByDescending(p => p.UnitPrice)
               .Take(3);

            //Q02




        }
    }
}
