// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// DisplayEmail(corporate);
// DisplayEmail(external, externalDomain);

// void DisplayEmail(string[,] names, string domain = "contoso.com")
// {
//   for (int i = 0; i < names.GetLength(0); i++)
//   {
//     string userName = names[i, 0].Substring(0, 2);
//     userName += names[i, 1];

//     Console.WriteLine($"{userName.ToLower()}@{domain}");
//   }
// }