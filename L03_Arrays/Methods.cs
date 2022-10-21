using System.Data;

namespace L03_Arrays;
/*
    You might feel lost in some of the following problems, because
    their domains might be outside of your comfort zone.
    THIS IS ABSOLUTELY NORMAL and you should not act with fear.
    This will happen very often during your life as a software developer,
    and "I don't know a sh** about this", "I'm not a mathematician", etc.
    will never be acceptable answers to your manager.
    
    The only useful thing that can be done when we face a problem from 
    which domain we know nothing is to research. Pay attention to the
    "weird" words mentioned and google them. Get to know what the problem
    is talking about. Sometimes the problem is not that hard. Don't let
    a fancy/unknown word/definition to keep you from solving the problem.    
*/
static class Methods
{
    // Returns the maximum number contained in an array
    public static int Maximum(int[] numbers) 
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    } // Done

    // Finds the second largest number in an array.
    public static int SecondLargest(int[] numbers)
    {
        int max = Maximum(numbers);
        int seclargest = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            int diff = int.MaxValue;
            if ( (max - numbers[i]) <= diff && numbers.Length >= 2)
            {
                diff = max - numbers[i];
                seclargest = numbers[i];
            }
        }
        return seclargest;
    } // Done?


    // Finds the minvalue in an array.
    public static int Minimum(int[] numbers) // Finds the minvalue in an array.
    {
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }
    } // Done

    // Finds the second smallest value in an array.
    public static int SecondSmallest(int[] numbers)
    {
        return default;
    } // Done
    
  
    /// Determines whether the specified array contains the specified number
    /// <returns>True if the number is in the array, false otherwise</returns>
    /// <example>
    /// Contains({1,2,3,4,5}, 3) = true
    /// Contains({1,2,3,4,5}, 8) = false
    /// </example>
    public static bool Contains(int[] numbers, int number)
    {   
        // Bool 
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                return true;
            }
        }
        return false;
    } // Done
    
    /// Computes the average of all numbers in the specified array
    public static double Average(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }
        var average = sum / numbers.Length; 
        
        return average;
    } // Done
    
    /// Returns the amount of numbers in the specified array
    /// which are greater than the average of all numbers in the array 
    /// CountGreaterThanAverage({1,2,3,4,5}) = 1
    /// CountGreaterThanAverage({2,10,5,8,17}) = 2
    public static int CountGreaterThanAverage(int[] numbers)
    {
        int count = 0;
        double avg = numbers.Average();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > avg)
            {
                count++;
            }
        }
        return count;
    }
    
    /// Swaps the elements in position i and j in the specified array
    /// int[] arr = {1,2,3,4,5}
    /// Swap(arr, 1, 3)
    /// arr == {1,4,3,2,5}
    public static void Swap<T>(T[] items, int i, int j)
    {
        if (i != j)
        {
            var temp = items[i]; // temporary variable storing items[i] in.
            items[i] = items[j]; 
            items[j] = temp;
        }
    }
    
    /// Returns an array with the same elements as the specified array
    /// Clone({1,2,3}) = {1,2,3}
    /// Clone({ }) = { }
    public static T[] Clone<T>(T[] items)
    {
        int spaces = items.Length;
        T[] clone = new T[spaces];
        for (int i = 0; i < spaces; i++)
        {
            clone[i] = items[i];
        }
        return clone;
    }
    
    /// Returns an array with the same elements of the specified
    /// array, but in reversed order
 
    /// SortAscending({1,2,3,4,5}) = {5,4,3,2,1}
    public static T[] Reverse<T>(T[] items)
    {
        var reverse = new T[items.Length]; // Declare the reversed array with same number of "slots" as items
        int j = items.Length - 1; // Declare new variable j for indexing of reverse array

        for (int i = 0; i < items.Length ; i++)
        {
            items[j] = items[items.Length - j];
            j--;
        }
        return reverse;
    }
    
    /// <summary>
    /// Returns a portion of the specified array, starting at
    /// startIndex, and a length of at most length.
    /// 
    /// Assume that startIndex >= 0
    /// </summary>
    /// <example>
    /// Slice({1,2,3,4,5}, 1, 2) = {2,3}
    /// Slice({1,2,3,4,5}, 3, 2) = {4,5}
    /// Slice({1,2,3,4,5}, 3, 5) = {4,5}
    /// Slice({1,2,3,4,5}, 8, 3) = { }
    /// </example>
    public static T[] Slice<T>(T[] items, int startIndex, int length)
    {
        T[] sliceitems = new T[length];
        if (startIndex + length < items.Length)
        {
            for (int i = 0; i < length; i++)
            {
                sliceitems[i] = items[startIndex + i];
            }
        }
        return sliceitems;
        
    }
    
    /// <summary>
    /// Returns an array with the same elements of the specified
    /// array, but sorted in ascending order
    /// </summary>
    /// <example>
    /// SortAscending({5,3,2,1,4}) = {1,2,3,4,5}
    /// </example>
    public static int[] SortAscending(int[] items)
    {
        int j = items.Length;
        for (int i = 0; i < items.Length; i++)
        {
            
        }
        return default;
    }
    /// <summary>
    /// Computes the addition of the specified matrices.
    /// OBS: Assume that m1 and m2 have compatible ranks
    /// </summary>
    /// <returns>The resulting matrix</returns>
    public static double[,] MatrixAdd(double[,] m1, double[,] m2)
    {
        return default;
    }
    
    /// <summary>
    /// Returns an array containing all prime numbers up to the
    /// specified number (inclusive)
    ///
    /// Assume max >= 0
    /// </summary>
    /// <example>
    /// PrimesUpTo(10) = {2,3,5,7}
    /// PrimesUpTo(1) = { }
    /// PrimesUpTo(0) = { }
    /// </example>
    /*public static int[] PrimesUpTo(int max)
    {
        // Create array from index 0 to max --> max+1 spaces.
        bool[] notprimes = new bool[max + 1];
        
        for (int i = 0; i <= max; i++)
        {
            notprimes[i] = true;
        }

        //int[] nbrserie = new int[max];
        int[] primes = new int[max];
        primes[0] = 1;
        for (int i = 2; i <= primes.Length; i++)
        {
            if (i*i + i = )
            primes[i] = 
        }
        for (int i = 2; i <= max; i++)
        {
            nbrserie[i] = i; // Fill 
        }
        
        for (int j = 0; j < nbrserie.Length; j++)
        {
            if (nbrserie[j] % j == 0)
            {
                nbrserie[j].
            }
        }
        return default;
    }*/

    #region For enthusiasts
    /// <summary>
    /// Computes the prime factorization of the specified number.
    /// The factorization is represented with an array of integers
    /// as follows: the index represents the prime factor and
    /// the value holds the exponent.
    /// Notice that the non-prime indices must always be 0
    /// </summary>
    /// <example>
    /// 9 = 3 * 3 = 3^2
    /// 12 = 2 * 2 * 3 = 2^2 * 3
    /// </example>
    /// <example>
    /// PrimeFactorization(8) = {0,0,3}
    /// PrimeFactorization(300) = {0,0,2,1,0,2}
    /// </example>
    public static int[] PrimeFactorization(int n)
    {
        
        return default;
    }

    /// <summary>
    /// Evaluates the polynomial represented by the specified array
    /// at the specified point x.
    ///
    /// The representation is as follows: The indices represent the
    /// degrees of the terms and the values represent the coefficients
    /// </summary>
    /// <example>
    /// The representation of the polynomial
    /// 2*x^2 + 3*x + 1
    /// is
    /// {1, 3, 2}
    /// OBS: ^ means in this case power, not XOR.
    /// x^2 means x to the power of 2, not x XOR 2
    /// </example>
    /// <example>
    /// EvaluatePolynomial({1,3,2}, 2) = 15
    /// EvaluatePolynomial({1,2,1}, 0) = 1
    /// </example>
    public static int EvaluatePolynomial(int[] coefficients, int x)
    {
        return default;
    }
    /// <summary>
    /// Computes the sum of the specified polynomials
    /// </summary>
    /// <example>
    /// AddPolynomials({1,2,1}, {2,3,4}) = {3,5,5}
    /// AddPolynomials({5}, {1,2,1}) = {6,2,1}
    /// </example>
    public static int[] AddPolynomials(int[] p, int[] q)
    {
        return default;
    }
    
    /// <summary>
    /// Computes the product of the specified polynomials
    /// </summary>
    public static int[] MultiplyPolynomials(int[] p, int[] q)
    {
        return default;
    }
    /// <summary>
    /// Determines whether the specified sudoku solution is valid or not.
    /// 0 represents an empty square
    /// Assume that sudoku is always 9x9
    /// </summary>
    /// <example>
    /// IsValidSudokuSolution({
    ///     {5,3,4,  6,7,8,  9,1,2},
    ///     {6,7,2,  1,9,5,  3,4,8},
    ///     {1,9,8,  3,4,2,  5,6,7},
    /// 
    ///     {8,5,9,  7,6,1,  4,2,3},
    ///     {4,2,6,  8,5,3,  7,9,1},
    ///     {7,1,3,  9,2,4,  8,5,6},
    ///
    ///     {9,6,1,  5,3,7,  2,8,4},
    ///     {2,8,7,  4,1,9,  6,3,5},
    ///     {3,4,5,  2,8,6,  1,7,9}
    /// }) = true
    /// </example>
    /// <returns>true if valid, false otherwise</returns>
    public static bool IsValidSudokuSolution(byte[,] sudoku)
    {
        return default;
    }
    #endregion
}
    
    
