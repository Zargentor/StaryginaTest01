using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArrayProcessingApp
{
    public class ArrayProcessor
    {
        // Метод для поиска пар (a_i, a_{i+1}), таких что a_i кратно 3 и a_{i+1} < 0
        public (int index1, int value1, int index2, int value2)[] FindPairs(int[] array)
        {
            var pairs = new List<(int index1, int value1, int index2, int value2)>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] < 0)
                {
                    pairs.Add((i, array[i], i + 1, array[i + 1]));
                }
            }

            return pairs.ToArray();
        }

        // Метод для чтения входных данных из файла и обработки их
        public void ProcessFile(string inputFile)
        {
            try
            {
                string[] lines = File.ReadAllLines(inputFile);

                foreach (var line in lines)
                {
                    int[] numbers = line.Split(',')
                                        .Select(s => int.TryParse(s, out var n) ? n : int.MinValue)
                                        .Where(n => n != int.MinValue)
                                        .ToArray();

                    if (numbers.Length == 0)
                    {
                        Console.WriteLine($"Input: {line} -> Error: Invalid data");
                        continue;
                    }
                    if (numbers.Length > 1024)
                    {
                        Console.WriteLine($"Input: {line} -> Error: Array length exceeds 1024 elements.");
                        continue;
                    }

                    try
                    {
                        var result = FindPairs(numbers);
                        if (result.Length == 0)
                        {
                            Console.WriteLine($"Input: {line} -> No valid pairs found.");
                        }
                        else
                        {
                            foreach (var pair in result)
                            {
                                Console.WriteLine($"Pair found: Index {pair.index1} ({pair.value1}), Index {pair.index2} ({pair.value2})");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Input: {line} -> Error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file: {ex.Message}");
            }
        }
    }
}