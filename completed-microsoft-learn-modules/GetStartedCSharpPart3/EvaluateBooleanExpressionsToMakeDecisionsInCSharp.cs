// Console.WriteLine("1: " + ("a" == "a"));
// Console.WriteLine("2: " + ("a" == "A"));
// Console.WriteLine("3: " + (1 == 2));

// string myValue = "a";
// Console.WriteLine("4: " + (myValue == "a"));

// Console.WriteLine("5: " + ("a" == "a "));

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine("6: " + (value1.Trim().ToLower() == value2.Trim().ToLower()));

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// // These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// int saleAmount = 108;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// int flipResult = coin.Next(0, 2);
// Console.WriteLine($"{(flipResult == 0 ? "Heads" : "Tails")}");


string permission = "Barkeep";
int level = 17;
if (permission.Contains("Admin"))
{
	Console.WriteLine(level > 55 ? "Welcome, Super Admin user" : "Welcome, Admin user");
}
else if (permission.Contains("Manager") && level >= 20)
{
	Console.WriteLine("Contact an Admin for access.");
}
else
{
	Console.WriteLine("You do not have sufficient privileges.");
}