
// GuidedProjectCalculateFinalGpa.cs

// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;
// int gradeC = 2;
// int gradeD = 1;
// int gradeF = 0;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;


// int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

// int totalGradePoints = (course1Grade * course1Credit) + (course2Grade * course2Credit) + (course3Grade * course3Credit) + (course4Grade * course4Credit) + (course5Grade * course5Credit);

// decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
// Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
// Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
// Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
// Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

// Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

// Console.WriteLine($"Final GPA: {gradePointAverage}");

// int leadingDigit = (int)gradePointAverage;

// int firstDecimalDigit = (int)(gradePointAverage * 10) % 10;
// int secondDecimalDigit = (int)(gradePointAverage * 100) % 10;

// Console.WriteLine($"Student: {studentName}\n");
// Console.WriteLine($"Course\t\t\tGrade\tCredit Hours");
// Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
// Console.WriteLine("\n");

// Console.WriteLine($"Final GPA: {leadingDigit}.{firstDecimalDigit}{secondDecimalDigit}");