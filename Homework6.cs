//Q1


/*namespace Homework6
{
        
        //Code for Professor
    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string className, double initialSalary)
        {
            profName = name;
            classTeach = className;
            salary = initialSalary;
        }

        public string ProfName
        {
            get { return profName; }
            set { profName = value; }
        }

        public string ClassTeach
        {
            get { return classTeach; }
            set { classTeach = value; }
        }

        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public void Display()
        {
            System.Console.WriteLine("Professor: " + profName + ", Teaches: " + classTeach + ", Salary: " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);

            professor1.Display();
            professor2.Display();
        }
    }
}*/

    //Code for Student

   /*{
    class Student
    {
        public string studentName { get; set; }
        public string classEnroll { get; set; }

        private double studentGrade;
        public double StudentGrade
        {
            get { return studentGrade; }
            private set { studentGrade = value; }
        }

        public Student(string name, string enroll, double grade)
        {
            studentName = name;
            classEnroll = enroll;
            StudentGrade = grade;  
        }

        public void SetGrade(double newGrade)
        {
            StudentGrade = newGrade;  
        }

        public void Display()
        {
            System.Console.WriteLine($"Student: {studentName}, Enrolled in: {classEnroll}, Grade: {StudentGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            student1.Display();
            student2.Display();
        }
    }
}*/



//Q2


/*namespace Homework6
{
    class Professor
    {
        public string profName { get; set; }
        public string classTeach { get; set; }
        public double salary { get; set; }

        public Professor(string name, string className, double initialSalary)
        {
            profName = name;
            classTeach = className;
            salary = initialSalary;
        }

        public void Display()
        {
            System.Console.WriteLine($"Professor: {profName}, Teaches: {classTeach}, Salary: {salary}");
        }
    }

    class Student
    {
        public string studentName { get; set; }
        public string classEnroll { get; set; }
        public double studentGrade { get; set; }

        public Student(string name, string enroll, double grade)
        {
            studentName = name;
            classEnroll = enroll;
            studentGrade = grade;
        }

        public void Display()
        {
            System.Console.WriteLine($"Student: {studentName}, Enrolled in: {classEnroll}, Grade: {studentGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);

            professor1.Display();
            professor2.Display();

            double salaryDifference = professor1.salary - professor2.salary;
            System.Console.WriteLine($"Salary difference between Alice and Bob: {salaryDifference}");

            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);
            student1.Display();
            student2.Display();

            double totalGrade = student1.studentGrade + student2.studentGrade;
            System.Console.WriteLine($"Total grade for Lisa's Java course and Tom's Math course: {totalGrade}");
        }
    }
}*/