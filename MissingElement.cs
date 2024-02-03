/*

// We seem to have lost one of our sequence elements, and we need your help to retrieve it!

// Our sequence given was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

// Write a function that accepts a sequence of unique integers between 0 and 9 (inclusive), and returns the missing element.

// */

// Console.WriteLine("Result is: {0}", MissingElement([0, 5, 1, 3, 2, 9, 7, 6, 4]));
// Console.WriteLine("Result is: {0}", MissingElement([9, 2, 4, 5, 7, 0, 8, 6, 1]));

// int MissingElement(int[] intArray)
// {
//   // Codewars
//   // return (int)Enumerable.Range(0, 9).Except(intArray).FirstOrDefault();

//   for (int i = 0; i < 10; i++)
//   {
//     if (Array.IndexOf(intArray, i) == -1)
//     {
//       return i;
//     }
//   }
//   return -1;
// }