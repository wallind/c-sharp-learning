// PerformBasicStringFormatting.cs

// Console.WriteLine("Hello\nEurope!");
// Console.WriteLine("Hello\tAustralia!");

// Console.WriteLine("Hello \"freedom\"!");

// Console.WriteLine("This is the C drive C:\\");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t");
// Console.Write(@"C:\Invoices\2024\June");


// Console.WriteLine(@"       c:\source\repos
//         (this is where your code goes)");

// Kon'nichiwa World
// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"c:\invoices\app.exe -j");

// string fullName = "Bob Belcher";
// string job = "Chef";
// // string message = "Hello " + fullName + ", you are a " + job + ".";
// // Console.WriteLine(message);
// Console.WriteLine("Hello " + fullName + ", you are a " + job + ".");
// // instead, do interpolation :)
// Console.WriteLine($"Hello {fullName}, you are a {job}.");
// // or, use the format method
// Console.WriteLine("Hello {0}, you are a {1}.", fullName, job);

// int age = 35;
// Console.WriteLine($"{fullName} is {age} years old.");

// // verbatim literal and interpolation
// Console.WriteLine(@$"Hello {fullName}, your files are stored at C:\Users\{fullName}\Documents\Invoices\2024\June");
// Console.WriteLine($@"Hello {fullName}, your files are stored at C:\Users\{fullName}\Documents\Invoices\2024\June"); // seems to work in either order

// string projectName = "ACME";

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");
// Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");