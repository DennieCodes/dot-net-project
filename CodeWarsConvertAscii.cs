// /*

// Given a string, turn each character into its ASCII character code and join them together to create a number - let's call this number total1:

// 'ABC' --> 'A' = 65, 'B' = 66, 'C' = 67 --> 656667

// Then replace any incidence of the number 7 with the number 1, and call this number 'total2':

// Then return the difference between the sum of the digits in total1 and total2:

//   (6 + 5 + 6 + 6 + 6 + 7)
// - (6 + 5 + 6 + 6 + 6 + 1)
// -------------------------
//                        6
// */

// using System.Text;
// // using System.Linq;


// Console.WriteLine(Calc("ABC"));
// // Console.WriteLine(BestCalc("ABC"));

// int BestCalc(string s)
// {
//   return string.Concat(s.Select(x => (int)x)).Count(x => x == '7') * 6;
//   // return string.Join("", string.Join("", s.Select(c => (int)c)).ToCharArray().Where(c => c == '7')).Length * 6;
// }

// int Calc(string s)
// {
//   // Convert each letter into ASCII value
//   // byte[] asciiBytes = Encoding.ASCII.GetBytes(s);

//   // Convert the array into a string
//   string total1 = String.Join("", Encoding.ASCII.GetBytes(s));
//   string total2 = total1.Replace("7", "1");

//   // Convert string into array of individual characters
//   string[] arr1 = total1.Split("");
//   string[] arr2 = total2.Split("");

//   Console.WriteLine("Test: {0}", string.Concat(arr1));

//   // Following two lines use LINQ which doesnt work on Codewars
//   // int sum1 = total1.Split("").Aggregate(0, (acc, cur) => acc + int.Parse(cur));
//   // int sum2 = total2.Split("").Aggregate(0, (acc, cur) => acc + int.Parse(cur));
//   int sum1 = 0;
//   int sum2 = 0;

//   foreach (string i in arr1) sum1 += int.Parse(i);
//   foreach (string i in arr2) sum2 += int.Parse(i);

//   return sum1 - sum2;
// }
