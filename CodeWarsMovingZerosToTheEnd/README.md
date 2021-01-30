# CodeWarsAnswers
Problem Name: Moving Zeros To The End

Problem: Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
Solution:

	public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

Solution Description: In my solution, I used OrderBy(x=> x==0)
OrderBy acting like a standard for loop and at the same time converting array. 
As a result of this complexity is O(N).