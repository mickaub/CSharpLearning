using System; 
// up to check your work .10

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = new int[] {90,86,87,98,100,94,90};
int[] andrewScores = new int[] {92,89,81,96,90,89};
int[] emmaScores = new int[] {90,85,87,98,68,89,89,89};
int[] loganScores = new int[] {90,95,87,88,96,96};
int[] beckyScores = new int[] {92,91,90,91,92,92,92};
int[] chrisScores = new int[] {84,86,88,90,92,94,96,98};
int[] ericScores = new int[] {80,90,100,80,90,100,80,90};
int[] gregorScores = new int[] {91,91,91,91,91,91,91};

//student names
string[] studentNames = new string[] {"Sophia","Andrew","Emma","Logan","Becky","Chris","Eric","Gregor"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")        
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    
    else   
        continue;

    // ititialising exam score variable and also decimal to store the final result
    int examScore = 0;
    decimal examScoreTotal = 0;

    //temporarily recording extra credit total as 0, worth 0 points        
    int extraCreditScores = 0;
    decimal extraCreditTotal = 0;
    decimal extraCreditAverage = 0;
    int extraCreditQuantity = 0;
    decimal extraCreditPoints = 0;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // intialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    //initialize/reset a counter for the number of assignments
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        //increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)           
        {   
            // add the exam score to the sum
            sumAssignmentScores += score;
            examScore += score;
        }
        else
        {
            //add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score/10;
            extraCreditScores += score;
            extraCreditQuantity ++;
        }    
            
    }
        
    examScoreTotal = (decimal) (examScore) / examAssignments;
    extraCreditTotal = (decimal) (extraCreditScores) / extraCreditQuantity;
    extraCreditAverage = (decimal) (extraCreditScores) / 10;    
    extraCreditPoints = (decimal) (extraCreditAverage) / examAssignments;

    currentStudentGrade = (decimal) (examScoreTotal) + extraCreditPoints;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    
    Console.WriteLine($"{currentStudent}:\t\t{examScoreTotal}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{extraCreditTotal}\t({extraCreditPoints} pts)");
}

//Console.WriteLine("Press the Enter key to continue");
//Console.ReadLine();