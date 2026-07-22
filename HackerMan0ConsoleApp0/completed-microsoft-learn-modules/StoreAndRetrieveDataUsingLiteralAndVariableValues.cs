// *** Store and retrieve data using literal and variable values in C# *** START //

// Console.WriteLine('b');
// Console.WriteLine('Hello, World!'); -> This line will not compile because single quotes are used for char literals, and "Hello, World!" is a string literal. Use double quotes for strings.
// Console.WriteLine(1234);

// Console.WriteLine(420.420F); // The 'F' suffix indicates that this is a float literal. Without it, the number would be treated as a double by default.; reminds me of Kotlin
// Console.WriteLine(2.2f); // lowercase 'f' can also be used to indicate a float literal.
// Console.WriteLine(2.625); // double literal by default, no suffix needed.
// Console.WriteLine(2.43D); // The 'D' suffix indicates that this is a double literal. However, it is optional since double is the default type for floating-point literals.
// Console.WriteLine(11.77456m); // The 'm' suffix indicates that this is a decimal literal. Without it, the number would be treated as a double by default.
// Console.WriteLine(11.77456M); // uppercase 'M' can also be used to indicate a decimal literal.

// Console.WriteLine(true); // boolean literal (prints as "True" in the console)
// Console.WriteLine(false); // boolean literal (prints as "False" in the console)

// now onto variables

// string myName;

// bool isLearningCSharp;

// "wrong" = myName; // assignment goes right to left, so this won't compile

// myName = "HackerMan0";
// isLearningCSharp = true;

// int someNumber;

// someNumber = "Bob's Burgers"; // won't compile, wrong type. someNumber is an int, but "Bob's Burgers" is a string.

// Console.WriteLine(myName);
// myName = "HackerMan1";
// Console.WriteLine(myName);
// myName = "HackerMan2";
// Console.WriteLine(myName);
// myName = "HackerMan3";
// Console.WriteLine(myName);

// string uninitializedName;
// Console.WriteLine(uninitializedName);

// string initializedName = "HackerMan4";
// Console.WriteLine(initializedName);

// var message = "Don't tell me what to do ;)";
// message = 57233.1m;
// var cantDothis;

string name = "Bob";
int age;
age = 99;
var someNumber = 34.40M;

Console.Write("My name is ");
Console.Write(name);
Console.Write(" and I am ");
Console.Write(age);
Console.Write(" years old. My favorite number is ");
Console.Write(someNumber);