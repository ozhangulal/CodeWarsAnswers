# CodeWarsAnswers
Problem Name: Multiples of 3 or 5

Problem: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

Solution:

	public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }

Solution Description: In my solution, I used Enumerable.Range if you are using this code block Enumerable.Range acting
like a standard for loop. As a result of this complexity is O(N).