// Must have a foreach/for loop to process each string in array
// Should have a string var named myString
// The outer loop must use IndexOf to find the .
// Must use a variable periodLocation to determine where the . is in a string
// Must use a do-while or while to process myString variable.
// The inner loop must extract and display each sentence
// Do not display the .
// You must use the Remove, SubString or TrimStart function calls

// 1. Iterate over the array
// 2. Check if the sentence has a period
//    If not then display the sentence
// 3. If sentence has a period then iterate until it doesn't

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// foreach (string str in myStrings)
// {
//     string myString = str;
//     int periodLocation = str.IndexOf('.');

//     if (periodLocation != -1)
//     {
//         while (periodLocation != -1)
//         {
//             Console.WriteLine(myString.Remove(periodLocation));
//             myString = myString.Substring(periodLocation+1).TrimStart();
//             periodLocation = myString.IndexOf('.');
//         }
//     }
//     Console.WriteLine(myString);
// }
