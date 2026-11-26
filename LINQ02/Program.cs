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
            var pages = Source.ProductList
               .Skip(5)
               .Take(5);

            //Q03
            var Under25 = Source.ProductList
            .OrderBy(p => p.UnitPrice)
            .TakeWhile(p => p.UnitPrice < 25);

            //Q04
            var allseafoodinStock = Source.ProductList
              .Where(p => p.Category == "Seafood")
              .All(p => p.UnitsInStock > 0);

            //Q05
            int[] ids = { 3, 9, 13, 18 };
            var contains = ids.Contains(9);

            //Q06
            var count = Source.ProductList
                      .GroupBy(p => p.Category);
            foreach (var group in count)
            {
                Console.WriteLine($"{group.Key} has {group.Count()} products");
            }

            //Q07
            var prodactName = Source.ProductList
             .GroupBy(
             p => p.Category,
             p => p.ProductName
             );
            foreach (var group in prodactName)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var name in group)
                {
                    Console.WriteLine(name);
                }
            }



        }
    }
}
