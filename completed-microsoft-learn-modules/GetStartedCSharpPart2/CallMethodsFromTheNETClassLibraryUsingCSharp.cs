// string mine = "hullo";
// mine = mine.ToUpper();
// Console.WriteLine(mine);

// Random oldDice = new Random(); // old way to call constructor, not recommended anymore in newer SDK versions, just use `new()`
// Random dice = new();
// int roll = dice.Next(1, 20);
// Console.WriteLine($"You rolled a {roll}");
// Console.WriteLine($"re-roll! {dice.Next(1, 20)}");

// // int fail = Random.Next();

// Random moreDice = new Random();
// int roll1 = moreDice.Next();
// int roll2 = moreDice.Next(101);
// int roll3 = moreDice.Next(50, 100);

// Console.WriteLine($"First Roll: {roll1}");
// Console.WriteLine($"Second Roll: {roll2}");
// Console.WriteLine($"Third Roll: {roll3}");

// // dice.Next()

// // online docs..... but _why_ xD
// // https://learn.microsoft.com/en-us/dotnet/api/system.random.next?view=net-10.0

int bad = moreDice.Next(-1); // -> throws ArgumentOutOfRangeException
int good = moreDice.Next(0, 2); // -> works fine




int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);