using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Примерен вход
        string[] strings = { "test", "code", "fun", "recursion" };
        int k = 2; // Брой елементи в подмножествата

        Console.WriteLine($"Генериране на всички подмножества с точно {k} елемента:");
        GenerateSubsets(strings, k);
    }

    static void GenerateSubsets(string[] strings, int k)
    {
        List<string> currentSubset = new List<string>();
        GenerateSubsetsRecursive(strings, k, 0, currentSubset);
    }

    static void GenerateSubsetsRecursive(string[] strings, int k, int index, List<string> currentSubset)
    {
        // База на рекурсията: Ако сме избрали точно k елемента, отпечатваме текущото подмножество
        if (currentSubset.Count == k)
        {
            Console.WriteLine($"({string.Join(", ", currentSubset)})");
            return;
        }

        // База на рекурсията: Ако няма повече елементи за избор, приключваме
        if (index >= strings.Length)
        {
            return;
        }

        // Включване на текущия елемент в подмножеството
        currentSubset.Add(strings[index]);
        GenerateSubsetsRecursive(strings, k, index + 1, currentSubset);

        // Изключване на текущия елемент и преминаване към следващия
        currentSubset.RemoveAt(currentSubset.Count - 1);
        GenerateSubsetsRecursive(strings, k, index + 1, currentSubset);
    }
}
