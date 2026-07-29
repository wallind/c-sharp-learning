// // initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// // int sophiaTotal = 0;
// // int nicolasTotal = 0;
// // int zahirahTotal = 0;
// // int jeongTotal = 0;

// int sophiaTotal = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasTotal = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahTotal = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongTotal = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


// // Console.WriteLine($"Sophia: {sophiaTotal}");
// // Console.WriteLine($"Nicolas: {nicolasTotal}");
// // Console.WriteLine($"Zahirah: {zahirahTotal}");
// // Console.WriteLine($"Jeong: {jeongTotal}");

// decimal sophiaAverage = (decimal)sophiaTotal / currentAssignments;
// decimal nicolasAverage = (decimal)nicolasTotal / currentAssignments;
// decimal zahirahAverage = (decimal)zahirahTotal / currentAssignments;
// decimal jeongAverage = (decimal)jeongTotal / currentAssignments;

// // Console.WriteLine($"Sophia: {sophiaAverage}");
// // Console.WriteLine($"Nicolas: {nicolasAverage}");
// // Console.WriteLine($"Zahirah: {zahirahAverage}");
// // Console.WriteLine($"Jeong: {jeongAverage}");

// // 97 - 100    A+
// // 93 - 96     A
// // 90 - 92     A-
// // 87 - 89     B+
// // 83 - 86     B

// System.Func<decimal, string> calcGrade = (decimal average) =>
// {
// 	if (average >= 97)
// 		return "A+";
// 	else if (average >= 93)
// 		return "A";
// 	else if (average >= 90)
// 		return "A-";
// 	else if (average >= 87)
// 		return "B+";
// 	else if (average >= 83)
// 		return "B";
// 	else
// 		return "C";
// };

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine($"Sophia:\t\t {sophiaAverage} - Grade: \t{calcGrade(sophiaAverage)}");
// Console.WriteLine($"Nicolas:\t {nicolasAverage} - Grade: \t{calcGrade(nicolasAverage)}");
// Console.WriteLine($"Zahirah:\t {zahirahAverage} - Grade: \t{calcGrade(zahirahAverage)}");
// Console.WriteLine($"Jeong:\t\t {jeongAverage} - Grade: \t{calcGrade(jeongAverage)}");
