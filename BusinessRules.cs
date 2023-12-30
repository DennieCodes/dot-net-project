/*

Here are the Business Rules that your solution must satisfy:

If the user is an Admin with a level greater than 55, output the message:

Output

Copy
Welcome, Super Admin user.
If the user is an Admin with a level less than or equal to 55, output the message:

Output

Copy
Welcome, Admin user.
If the user is a Manager with a level 20 or greater, output the message:

Output

Copy
Contact an Admin for access.
If the user is a Manager with a level less than 20, output the message:

Output

Copy
You do not have sufficient privileges.
If the user is not an Admin or a Manager, output the message:

Output

Copy
You do not have sufficient privileges.

*/

// string permission = "Manager";
// int level = 56;

// if (permission.Contains("Admin") && level > 55) {
//     Console.WriteLine("Welcome, Super Admin user.");
// } else if (permission.Contains("Admin") && level <= 55) {
//     Console.WriteLine("Welcome, Admin user.");
// } else if (permission.Contains("Manager") && level >= 20) {
//     Console.WriteLine("Contact an Admin for access.");
// } else if (permission.Contains("Manager") && level < 20) {
//     Console.WriteLine("You do not have sufficient privileges");
// } else {
//     Console.WriteLine("You do not have sufficient privileges");
// }