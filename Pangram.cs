// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//   Console.WriteLine(item);
// }

/*

1. Convert the string into an array
2. Iterate over the array
3. Reverse the letter order of each word
4. Either convert the array back to a string to display
   or iterate and output the array

*/

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] arr = pangram.Split(" ");

// for (int i = 0; i < arr.Length; i++)
// {
//   char[] charArr = arr[i].ToCharArray();
//   Array.Reverse(charArr);
//   arr[i] = String.Join("", charArr);
// }

// Console.WriteLine(String.Join(" ", arr));