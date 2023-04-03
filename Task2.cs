class Task2
{
    private static Random rnd = new Random();
    static void Main(string[] args)
    {
        int rows = 8;
        int cols = 5;
        int[,] matrix = new int[rows,cols];
        create(matrix);
        print (matrix);
        Console.WriteLine("---------------------------");
        sort(matrix);
        print (matrix);
        Console.WriteLine("---------------------------");
        calculateSumAndCount(matrix);
    }
    private static void print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j].ToString() + "\t");
            }

            Console.WriteLine();
        }
    }

    private static void create(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-26, 24);
            }
        }
    }

    private static void sort(int[,] matrix)
    {
        for (int i0 = 0; i0 < matrix.GetLength(0) - 1; i0++)
        {
            for (int i1 = 0; i1 < matrix.GetLength(0) - i0 - 1; i1++)
            {
                if ((matrix[i1, 0] > matrix[i1 + 1, 0]) ||
                    (matrix[i1, 0] == matrix[i1 + 1, 0] && matrix[i1, 1] < matrix[i1 + 1, 1]) ||
                    (matrix[i1, 0] == matrix[i1 + 1, 0] && matrix[i1, 1] == matrix[i1 + 1, 1] &&
                     matrix[i1, 2] > matrix[i1 + 1, 2]))
                {
                    change(matrix, i1, i1 + 1, matrix.GetLength(1));
                }
            }
        }
    }

    private static void change(int[,] matrix, int row1, int row2, int colCount)
    {
        int tmp;
        for (int j = 0; j < colCount; j++)
        {
            tmp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = tmp;
        }
    }
    private static void calculateSumAndCount(int[,] matrix)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] > 0 && matrix[i,j] % 2 == 0)
                    continue;
                count++;
                sum += matrix[i,j];
            }
        }
        Console.WriteLine("Count elements: " + count);
        Console.WriteLine("Sum elements: " + sum);
    }
}
