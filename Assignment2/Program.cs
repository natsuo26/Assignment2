namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1 printing the sum and avg of elements of an Array
            int[] numbers=new int[] {1,2,6,7,1,3,2,4,5};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"The sum of array elements is: {sum}");
            int average = sum / numbers.Length;
            Console.WriteLine($"The average of array elements is: {average}");

            //q2 find sum of a 3X3 matrix
            int[,] matrix = new int[3,3] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 4, 1 } };
            int matrixSum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j < matrix.GetLength(1); j++)
                {
                    matrixSum+= matrix[i,j];   
                }
            }
            Console.WriteLine($"sum of the 3x3 matrix is : {matrixSum}");


            //q3 max element of an integer array
            int[] numbers2 = new int[] { 10, 99, 21, 300, 321, 931, 33, 20 };
            int max = int.MinValue;
            for(int i= 0; i < numbers2.Length; i++)
            {
                if(numbers2[i] > max)
                {
                    max = numbers2[i];
                }
            }
            Console.WriteLine($"max of array is : {max}");


            //q4 to print column wise sum of elements of 2D 
            int[,] array2d = new int[3, 4] { { 1, 2, 3 ,5}, { 3, 4, 5,2 }, { 5, 4, 1,8 } };
            for (int i=0;i< array2d.GetLength(1); i++)
            {
                int colSum = 0;
                for(int j = 0; j < array2d.GetLength(0); j++)
                {
                    colSum+= array2d[j,i];
                }
                Console.WriteLine($"the {i}th column sum is : {colSum}");
            }
            //q5 to print row wise sum of  elemented of 2d arr 
            for(int i = 0; i < array2d.GetLength(0); i++)
            {
                int rowSum = 0;
                for(int j=0;j<array2d.GetLength(1); j++)
                {
                    rowSum+= array2d[i,j];
                }
                 Console.WriteLine($"the {i}th row sum is : {rowSum}");
            }

        }
    }
}