using System;
using System.Collections.Generic;

// Лямбда-функції
Func<int, bool> evenFilter = x => x % 2 == 0;
Func<int, bool> oddFilter = x => x % 2 != 0;
Func<int, bool> greaterThan10Filter = x => x > 10;

// Делегат FilterDelegate
delegate List<int> FilterDelegate(List<int> numbers, Func<int, bool> filter);

class Program
{
    static void Main()
    {
        // Приклад вхідного масиву
        List<int> numbers = new List<int> { 5, 12, 3, 8, 15, 18, 9, 25 };

        // Метод для фільтрації та виведення результатів
        void FilterAndPrint(FilterDelegate filterDelegate, Func<int, bool> filter)
        {
            List<int> result = filterDelegate(numbers, filter);
            Console.WriteLine(string.Join(", ", result));
        }

        // Використання делегата для фільтрації та виведення результатів
        Console.WriteLine("Even numbers:");
        FilterAndPrint(Filter, evenFilter);

        Console.WriteLine("\nOdd numbers:");
        FilterAndPrint(Filter, oddFilter);

        Console.WriteLine("\nNumbers greater than 10:");
        FilterAndPrint(Filter, greaterThan10Filter);
    }

    // Метод, який використовує делегат для фільтрації
    static List<int> Filter(List<int> numbers, Func<int, bool> filter)
    {
        List<int> result = new List<int>();
        foreach (var number in numbers)
        {
            if (filter(number))
            {
                result.Add(number);
            }
        }
        return result;
    }
}
