namespace Homework9;

public class Student

//Q1


{
    private int studentID;
    private string studentName;

    public static Student[] studentList = new Student[100];
    public static int studentCount = 0;

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList[studentCount] = this;
        studentCount++;
    }

    public string GetName()
    {
        return studentName;
    }

    public void PrintInfo()
    {
        Console.WriteLine("ID: " + studentID + ", Name: " + studentName);
    }
}

public class Program
{
    public static void Main(string[] args)
    {


//Q2


        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");



//Q3



        string[] names = new string[100];
        double[] gpas = new double[100];
        int gradeCount = 0;

        names[gradeCount] = "Alice"; gpas[gradeCount++] = 4.0;
        names[gradeCount] = "Bob"; gpas[gradeCount++] = 3.6;
        names[gradeCount] = "Cathy"; gpas[gradeCount++] = 2.5;
        names[gradeCount] = "David"; gpas[gradeCount++] = 1.8;



    //Q4


        bool tomFound = false;
        for (int i = 0; i < gradeCount; i++)
        {
            if (names[i] == "Tom")
            {
                tomFound = true;
                break;
            }
        }

        if (!tomFound)
        {
            names[gradeCount] = "Tom";
            gpas[gradeCount++] = 3.3;
        }



//Q5


        double total = 0;
        for (int i = 0; i < gradeCount; i++)
        {
            total += gpas[i];
        }

        double average = total / gradeCount;
        Console.WriteLine("Average GPA: " + average.ToString("F2"));



//Q6


        Console.WriteLine("Students with GPA above average:");
        for (int i = 0; i < Student.studentCount; i++)
        {
            Student s = Student.studentList[i];
            string name = s.GetName();

            for (int j = 0; j < gradeCount; j++)
            {
                if (name == names[j] && gpas[j] > average)
                {
                    s.PrintInfo();
                    break;
                }
            }
        }
    }
}

