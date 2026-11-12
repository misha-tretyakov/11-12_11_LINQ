namespace  _11_12_11_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = list.Where(n => n > 5); // 6, 7, 8, 9, 10

            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
            
            Console.WriteLine("\n/////////////");
            
            
            var result2 = list.Select(n => n * 2);
            foreach (int x in result2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n/////////////");
            
            // ASC - sort by ascending
            // DESC - sort by descending
            var result3 = list.OrderBy(n => n); // ASC
            var result4 = list.OrderByDescending(n => n); // DESC

            Console.WriteLine("ASC");
            foreach (var x in result3)
            {
                Console.Write(x + " ");
            }
            
            
            Console.WriteLine("\nDESC");
            foreach (var x in result4)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            
            
            var first = list.First(n => n > 5);
            Console.WriteLine(first);
            
            var firstOrDef = list.FirstOrDefault(n => n > 10);
            Console.WriteLine(firstOrDef);
            
            int count = list.Count();
            int sum =  list.Sum();
            double avg = list.Average();

            var groups = list.GroupBy(n => n % 2);

            foreach (var group in groups)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var val in group)
                {
                    Console.WriteLine($"Value: {val}");
                }
            }

            Console.WriteLine("Filtering: ");
            var result5 = list.Where(n => n > 5)
                .OrderByDescending(n => n)
                .Select(n => n * 2);
            
            foreach (var n in result5)
            {
                Console.WriteLine(n);
            }
            
            // Query(SQL) style
            var result6 =
                from n in list
                where n > 5
                orderby n descending
                select n * 2;
        }
    }
}