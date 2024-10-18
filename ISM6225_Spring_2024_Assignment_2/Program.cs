using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
           try
            {
                int n = nums.Length; // Calculating the length of Array and assigning it to an integer n
                HashSet<int> set = new HashSet<int>(nums); // Using HashSet to track numbers in the array
                List<int> result = new List<int>(); // Storing missing numbers in a list
                
                // Checking for each number from 1 to n
                for (int i = 1; i <= n; i++)
                {
                    if (!set.Contains(i)) // If number is missing, adding to result
                    {
                        result.Add(i);
                    }
                }
                
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                List<int> result = new List<int>();  // // Initializing a list to store the result
    
    // Firstly Adding all even numbers to the result list in their original order
    foreach (int num in nums)
    {
        if (num % 2 == 0)   // Checking if the number is even
        {
            result.Add(num);  // Adding even number to the result list
        }
    }
    
    // Then, Adding all odd numbers to the result list in their original order
    foreach (int num in nums)
    {
        if (num % 2 != 0)   // Checking if the number is odd
        {
            result.Add(num);   // Adding odd number to the result list
        }
    }
    
    return result.ToArray();  // Converting the result list to an array and returning it
        }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> map = new Dictionary<int, int>(); // Dictionary to store number and its index
                
                // Traversing the array
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i]; // Finding the complement that would sum to the target
                    if (map.ContainsKey(complement)) // Checking if complement exists in the map
                    {
                        return new int[] { map[complement], i }; // Returning indices if found
                    }
                    map[nums[i]] = i; // Adding number and index to the map
                }

                return new int[0]; // Returning empty if no pair found
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                Array.Sort(nums); // Sorting the array to arrange elements
                int n = nums.Length;

                // The maximum product can either be the product of the top three numbers
                // Or the product of the two smallest (possibly negative) numbers and the largest number.
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                return Convert.ToString(decimalNumber, 2); // Using built-in function to convert decimal to binary
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0, right = nums.Length - 1;

                // Binary search to find the minimum element
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (nums[mid] > nums[right]) // If mid element is greater than right, minimum is on the right side
                    {
                        left = mid + 1;
                    }
                    else // Else, the minimum is on the left side
                    {
                        right = mid;
                    }
                }

                return nums[left]; // Returning the minimum element
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false; // Negative numbers cannot be palindromes

                int original = x, reversed = 0;

                // Reversing the number
                while (x > 0)
                {
                    reversed = reversed * 10 + x % 10; // Constructing the reversed number
                    x /= 10;
                }

                return original == reversed; // Checking if original is the same as reversed
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            //Using iteration
            try
            {
                if (n == 0) return 0; // Base case
                if (n == 1) return 1; // Base case

                int a = 0, b = 1;

                // Computing Fibonacci iteratively
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                return b; // Returning the nth Fibonacci number
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
