# Practic Labs 3

## Task 1: FizzBuzz
Write a method ```RunFizzBuzz()``` that returns the numbers from 1 to 100. But for multiples of three, returns "Fizz" instead of the number and for the multiples of five, returns "Buzz". For numbers which are multiples of both three and five, returns "FizzBuzz".


### Task 2: Sum of Even Numbers
Write a method ```SumOfEvens()``` that takes an integer `N` and returns the sum of all even numbers from 1 to `N`.


### Task 3: Reverse a String
Write a method ```ReverseString()``` that takes a string and returns it in reverse order.


### Task 4: Check for Prime Number
Write a method ```IsPrime()``` that takes an integer and returns `true` if it's a prime number, otherwise returns `false`.

### Task 5: Counting Vowels in a String

Write a method ```CountVowels()``` that takes a string as input and returns the count of vowels within that string. The vowels are 'a', 'e', 'i', 'o', and 'u' (both uppercase and lowercase should be considered). The method should be able to handle special characters, digits, and whitespace, but only alphabetic characters should be considered for counting vowels.

**Constraints:**
- The input string may contain letters, digits, whitespace, and special characters.
- Both uppercase and lowercase letters should be counted.
- Non-alphabetic characters should not affect the count.

### Task 6: Maximum Subarray Sum
Write a method ```FindMaxSum()``` that, given an array of integers, returns the largest sum of consecutive elements in the array. This problem, often referred to as the "Maximum Subarray Problem," requires identifying the contiguous part of the array that has the maximum sum. Negative numbers in the array can be part of the subarray if they are surrounded by positive numbers such that the total sum is maximized.

The function should iterate through the array, keeping track of the current subarray sum and the maximum subarray sum found so far. If the current subarray sum becomes negative, it should be reset to zero, as a negative subarray would not contribute to a maximum sum. The maximum subarray sum should be updated whenever a larger sum is found.

*Constraints:*
- The input array may contain positive, negative, and zero values.
- The size of the input array can vary, but you may assume it is non-empty.
- If the array contains all negative numbers, the maximum sum should be the largest negative number.
- If the array contains all non-positive numbers, the maximum sum is zero.

The algorithm should efficiently solve the problem with a time complexity of O(n), where n is the length of the input array. This is typically achieved using Kadane's algorithm.



