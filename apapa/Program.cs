using System.Xml.Linq;


namespace apapa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] ArrDouble = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ArrDouble[i, j] = rand.Next(-100, 101);
                }
            }

            Console.WriteLine("Massive 5 x 5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{ArrDouble[i, j],5} ");
                }
                Console.WriteLine();
            }

            int min = ArrDouble[0, 0];
            int max = ArrDouble[0, 0];
            (int minRow, int minCol) = (0, 0);
            (int maxRow, int maxCol) = (0, 0);
            int sum = 0;
            bool between = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ArrDouble[i, j] < min)
                    {
                        min = ArrDouble[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (ArrDouble[i, j] > max)
                    {
                        max = ArrDouble[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine($"Min element = {min}; Max element = {max}");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i == minRow && j == minCol) || (i == maxRow && j == maxCol))
                    {
                        if (between)
                        {
                            Console.WriteLine($"Result: {sum}");
                            return;
                        }
                        between = true;
                        continue;
                    }

                    if (between)
                    {
                        sum += ArrDouble[i, j];
                    }
                }
            }
        }
    }
}

