
// reference
// 97 - 100   A+
// 93 - 96    A
// 90 - 92    A-
// 87 - 89    B+
// 83 - 86    B
// 80 - 82    B-
// 77 - 79    C+
// 73 - 76    C
// 70 - 72    C-
// 67 - 69    D+
// 63 - 66    D
// 60 - 62    D-
// 0  - 59    F

// // initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 90;
// int sophia2 = 86;
// int sophia3 = 87;
// int sophia4 = 98;
// int sophia5 = 100;

// int andrew1 = 92;
// int andrew2 = 89;
// int andrew3 = 81;
// int andrew4 = 96;
// int andrew5 = 90;

// int emma1 = 90;
// int emma2 = 85;
// int emma3 = 87;
// int emma4 = 98;
// int emma5 = 68;

// int logan1 = 90;
// int logan2 = 95;
// int logan3 = 87;
// int logan4 = 88;
// int logan5 = 96;

// int sophiaSum = 0;
// int andrewSum = 0;
// int emmaSum = 0;
// int loganSum = 0;

// decimal sophiaScore;
// decimal andrewScore;
// decimal emmaScore;
// decimal loganScore;

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// refactored
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

foreach (int score in sophiaScores)
{
	sophiaSum += score;
}

foreach (int score in andrewScores)
{
	andrewSum += score;
}

foreach (int score in emmaScores)
{
	emmaSum += score;
}

foreach (int score in loganScores)
{
	loganSum += score;
}

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

decimal sophiaAverage = (decimal)sophiaSum / currentAssignments;
decimal andrewAverage = (decimal)andrewSum / currentAssignments;
decimal emmaAverage = (decimal)emmaSum / currentAssignments;
decimal loganAverage = (decimal)loganSum / currentAssignments;

Console.WriteLine($"Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaAverage + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewAverage + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaAverage + "\tB");
Console.WriteLine("Logan:\t\t" + loganAverage + "\tA-");

// got bored, aching to use a map but this lesson doesn't consider ready for it yet lmao.