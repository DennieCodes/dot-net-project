// string? readResult;
// int numericValue = 0;
// bool isValid = false;

// Console.WriteLine("Enter a integer value between 5 and 10: ");

// do
// {
//     readResult = Console.ReadLine();

//     if (int.TryParse(readResult, out numericValue))
//     {
//         if (numericValue >= 5 && numericValue <= 10) {
//             isValid = !isValid;
//             Console.WriteLine("Your input has been accepted.");
//         } else {
//             Console.WriteLine($"You entered {numericValue}.  Please enter a number between 5 and 10.");
//         }
//     } else {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (!isValid);