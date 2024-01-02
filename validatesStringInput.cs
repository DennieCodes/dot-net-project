// string? readResult;
// bool validInput = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do
// {
//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         string role = readResult.Trim().ToLower();

//         switch (role)
//         {
//             case "administrator":
//             case "manager":
//             case "user":
//                 validInput = true;
//                 break;

//             default:
//                 Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//                 break;
//         }
//     }


// } while (!validInput);

// Console.WriteLine($"Your input value ({readResult}) has been accepted");