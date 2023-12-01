using System;

namespace MyCustomSpace
{
    class Program
    {
        static void Main()
        {
            CustomGenList<int> customList = new CustomGenList<int>();

            // add lari test edriy
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            // count ve capacity test
            Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");

            // add methodun yoxlayiriq capacity artanda
            customList.Add(5);
            Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");

            // find-i yoxlamaq
            Console.WriteLine($"Find(3): {customList.Find(x => x == 3)}");

            // test FindAll
            CustomGenList<int> findAllResult = customList.FindAll(x => x % 2 == 0);
            Console.WriteLine($"FindAll(even): {string.Join(", ", findAllResult)}");

            // test Contains
            Console.WriteLine($"Contains(2): {customList.Contains(2)}");

            // test Exists 
            Console.WriteLine($"Exists(odd): {customList.Exists(x => x % 2 != 0)}");

            // test Remove
            customList.Remove(x => x == 3);
            Console.WriteLine($"After removing 3, Count: {customList.Count}, Capacity: {customList.Capacity}");
        }
    }
}
