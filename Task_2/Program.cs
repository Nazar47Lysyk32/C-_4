using System;
using System.Collections.Generic;
using System.Linq;

class Man
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Створення масиву людей
        List<Man> people = new List<Man>
        {
            new Man { Name = "John", Age = 30 },
            new Man { Name = "Alice", Age = 22 },
            new Man { Name = "Bob", Age = 17 },
            new Man { Name = "Emily", Age = 28 },
            new Man { Name = "David", Age = 15 }
        };

        // Знайти всіх людей, яким більше 25
        List<Man> olderThan25 = people.Where(man => man.Age > 25).ToList();

        // Видалити всіх людей, яким менше 18
        people.RemoveAll(man => man.Age < 18);

        // Відсортувати масив по іменах
        people.Sort((man1, man2) => string.Compare(man1.Name, man2.Name, StringComparison.Ordinal));

        // Вивести результати
        Console.WriteLine("People older than 25:");
        PrintPeople(olderThan25);

        Console.WriteLine("\nPeople after removing those younger than 18:");
        PrintPeople(people);
    }

    static void PrintPeople(List<Man> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
