namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesNumber;
            int columnsNumber;
            while (true)
            {
                Console.WriteLine("enter the number of lines");
                var lines = Console.ReadLine();
                if (int.TryParse(lines, out linesNumber))
                {
                    Console.WriteLine("enter the number of columns");
                    var columns = Console.ReadLine();
                    if (int.TryParse(columns, out columnsNumber))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("unknown element");
                    }
                }
                else
                {
                    Console.WriteLine("unknown element");
                }
            }
                int[,] matrix = new int[linesNumber, columnsNumber];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"element [{i},{j}] ");
                        int element = int.Parse(Console.ReadLine());
                        matrix[i, j] = element;
                    }
                }
                Result(matrix);

                Console.WriteLine("\nwhat kind of operation do you want to perform\n" +
                    "1: Find the number of positive/negative numbers in the matrix\n" +
                    "2: Inversion of matrix elements line by line\n" +
                    "3: Sorting matrix elements line by line\n");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (operation)
                {
                    case 1:
                        Task2(matrix);
                        break;
                    case 2:
                        Inversion(matrix);
                        break;
                    case 3:
                        Sorting(matrix);
                        break;
                }
        }

        static void Result(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

        static void Task2(int[,] matrix)
        {
            int positive = 0;
            int negative = 0;
            for (int i=0; i<matrix.GetLength(0);i++)
            {
                for (int j=0; j<matrix.GetLength(1);j++)
                {
                    if (matrix[i,j] >= 0)
                    {
                        positive++;
                    }
                    else if (matrix[i,j] < 0)
                    {  
                        negative++;
                    }
                }
            }
            Console.WriteLine("\nchoose" +
                "\n1:Positive" +
                "\n2:Negative");
            int choose = int.Parse(Console.ReadLine());
            switch (choose) 
            {
                case 1:
                    Console.WriteLine("Positive numbers in the matrix:" + positive);
                    break;
                case 2:
                    Console.WriteLine("Negative numbers in the matrix:" + negative);
                    break;
            }
        }
        
        static void Inversion(int[,] matrix) 
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int str = matrix.GetLength(1) / 2;
                for (int j = 0; j < str; j++)
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i, matrix.GetLength(1) - 1 - j];
                    matrix[i, matrix.GetLength(1) - 1 - j] = temp;
                }
                Console.WriteLine();
            }
            Result(matrix);
        }

        static void Sorting(int[,] matrix) 
        {
            int operation;
            while (true)
            {
                Console.Write("1:sort in ascending\n" +
                    "2:sort in descending:");
                var choice = Console.ReadLine();
                if (int.TryParse(choice, out operation)) 
                { 
                break;
                }
                else
                {
                    Console.WriteLine("unknown element");
                }
            }
            switch (operation)
            {
                case 1:
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            for(int k = 0; k < matrix.GetLength(1) - 1 ; k++)

                            if (matrix[i,k] > matrix[i, k + 1] )
                            {
                                int temp = matrix[j, k];
                                matrix[i, k] = matrix[i,k + 1];
                                matrix[i,k + 1] = temp;
                            }
                        }
                    }
                    Result(matrix);
                break;

                case 2:
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            for (int k = 0; k < matrix.GetLength(1) - 1; k++)

                                if (matrix[i, k] < matrix[i, k + 1])
                                {
                                    int temp = matrix[j, k];
                                    matrix[i, k] = matrix[i, k + 1];
                                    matrix[i, k + 1] = temp;
                                }
                        }
                    }
                    Result(matrix);
                break;
            }
        }
    }    

}

