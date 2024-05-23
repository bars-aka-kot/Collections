namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
            int target = 80;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} + {arr[k]}");
                        }
                    }
                }
            }
            Console.WriteLine("Второй метод");
            var s = new HashSet<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                foreach (var j in arr)
                {
                    var x = target - j - i;
                    if (s.Contains(x))
                    {
                        Console.WriteLine($"{x} + {i} + {j}");
                    }
                    else s.Add(j);
                }
            }
        }
    }
}
