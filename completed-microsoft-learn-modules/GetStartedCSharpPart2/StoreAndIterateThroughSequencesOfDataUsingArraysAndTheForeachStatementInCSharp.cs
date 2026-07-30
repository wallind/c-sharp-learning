// string[] fraudulentOrderIDs = new string[3];

/* 
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs.Append("B456");
fraudulentOrderIDs.Append("C789");

Console.WriteLine($"The first fraudulent order ID is {fraudulentOrderIDs[0]}.");

// fraudulentOrderIDs[3] = "D000"; // This will hit "IndexOutOfRangeException" exception.

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"The updated first fraudulent order ID is {fraudulentOrderIDs[0]}");
*/
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // older sytanx
// string[] fraudulentOrderIDs = ["A123", "B456", "C789"]; // newer syntax
// Console.WriteLine($"The first fraudulent order ID is {fraudulentOrderIDs[0]}.");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} order IDs in the list.");

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
// 	Console.WriteLine(name);
// }

// int sum = 0;
// int bin = 0;

// int[] inventory = { 200, 450, 700, 175, 250 };

// foreach (int itemCount in inventory)
// {
// 	bin++;
// 	sum += itemCount;

// 	Console.WriteLine($"{itemCount} in bin {bin}\t\tRunning Total {sum}");
// }
// Console.WriteLine($"The total inventory is {sum}");

// B123
// C234
// A345
// C15
// B177
// G3003
// C235
// B179
string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string order in orders)
{
	if (order.StartsWith("B"))
	{
		Console.WriteLine($"!!! Fradulent order detected !!! \t\t OrderID: {order}");
	}
	else
	{
		Console.WriteLine($"OrderID: {order}");
	}
}