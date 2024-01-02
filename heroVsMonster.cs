// Random random = new Random();
// int heroHealth = 10;
// int monsterHealth = 10;

// do
// {
//     int heroAttack = random.Next(1, 10);
//     monsterHealth -= heroAttack;
//     Console.WriteLine($"The monster lost {heroAttack} health and has {(monsterHealth > 0 ? monsterHealth : 0)} health");

//     if (monsterHealth > 0) {
//         int monsterAttack = random.Next(1, 10);
//         heroHealth -= monsterAttack;
//         Console.WriteLine($"The hero lost {monsterAttack} health and has {(heroHealth > 0 ? heroHealth : 0)} health");
//     }

// } while (heroHealth > 0 && monsterHealth > 0);

// if (monsterHealth <= 0)
// {
//     Console.WriteLine("The hero won!");
// } else {
//     Console.WriteLine("The monster won!");
// }

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");