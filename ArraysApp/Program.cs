namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            int[] arr2 = {1, 2, 3, 4, 5 };
            int[] arr3;
            arr3 = new int[] { 1, 2, 3, 4, 5 };


            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach(var num in arr2)
            {
                Console.WriteLine(num);
            }



        }

        public static int GetMinPosition(int[] arr)
        {
            int minPos = 0;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minPos])
                {
                    min = arr[i];
                    minPos = i;
                }
            } return minPos;

        }

        public static bool IsSymmetric(int[] arr)
        {
            for(int i = 0 , j = arr.Length - 1; i < j;  i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
               
            }
            return true;
        }

        /// <summary>
        /// Finds the best 2x2 sum in a 2D matrix and returns the sum along with its position (row and column).
        /// For example, in the matrix: 
        /// {
        ///     { 1, 2, 3 },
        ///     { 4, 5, 6 },
        ///     { 7, 8, 9 }
        /// }
        /// 
        /// Best sum is 28 (5, 6, 8, 9) at position (1, 2) (0-based index).
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static (long bestSum, int bestRow, int bestCol) FindBestSum(int[,] matrix)
        {
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            long sum = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }

            return (bestSum, bestRow, bestCol);
        }
    }
}
      

    }
}
