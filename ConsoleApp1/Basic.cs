using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace School
{
    
    public class Basic
    {
        public static void CreateClassRoom(List<Student> classRoom)
        {
            //Variables
            string name = "random";
            name = "jane";
            int grade = 12;
            bool isFemale = true;
            float height = 1.6f;

            //Lists
            int[] numbers = { 1, 2, 3 };

            numbers[1] = 10;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Student jane = new Student(grade, height, name, isFemale);
            Student john = new Student(4, 1.84f, "John", false);
            Student mark = new Student(7, 1.74f, "Mark", false);
            Student lisa = new Student(2, 1.64f, "Lisa", true);
            Student jessica = new Student(10, 1.54f, "Jessica", true);
            Student Hamudi = new Student(4, 1.44f, "Hamudi", false);

            classRoom.Add(john);
            classRoom.Add(jane);
            classRoom.Add(mark);
            classRoom.Add(lisa);
            classRoom.Add(jessica);
            classRoom.Add(Hamudi);

            //Loops
            // foreach (Student student in classRoom)
            // {
            //     Console.WriteLine(student.Name);
            // }
            for (int i = 0; i < classRoom.Count; i++)
            {
                Console.WriteLine(classRoom[i].Name);
            }
        }

        // ?  Write a program that calculates and returns
        // ?  the average grades of all students in the classRoom.
        public static double CalculateAverageRate(List<Student> classRoom)
        {
            int sumGrade = 0;
            // TODO: sum of all grades / number of students
            // TODO: Add all grades together
            for (int i = 0; i < classRoom.Count; i++)
            {
                int grade = classRoom[i].Grade;
                sumGrade += grade;
            }
            double averageGrade = sumGrade / classRoom.Count;
            return averageGrade;
        }

        // ?  Write a program that calculates and returns
        // ?  the average height of all female students in the classRoom.
        public static float CalculateAverageHeight(List<Student> classRoom)
        {
            float sumHeight = 0;
            int FemaleStudents = 0;

            for (int i = 0; i < classRoom.Count; i++)
            {
                Student student = classRoom[i];
                if (student.IsFemale == true)
                {
                    float femaleHeight = student.Height;
                    sumHeight = sumHeight + femaleHeight;
                    //! sumHeight += femaleHeight;
                    FemaleStudents = FemaleStudents + 1;
                    //! FemaleStudents++;
                }
            }
            Console.WriteLine($"count is: {FemaleStudents}");
            float averageHeight = sumHeight / FemaleStudents;
            return averageHeight;
        }

        /*
        ? Write a program that takes an array of integers
        ? and creates two lists, one containing even numbers
        ? and the other containing odd numbers.
        ? Define a class with a constructor and each list as a property.
        ? return an instance of the class with the two lists as properties.
        */

        
        public static Wrapper SortNumbers(int[] randomNumbers)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            foreach (int number in randomNumbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }
            Wrapper wrapper = new Wrapper(evenNumbers,oddNumbers);
            return wrapper;
        }
    }
    public class Wrapper
    {
     private List<int> evenNumbers;

     private List<int> oddNumbers;
       public List<int> EvenNumbers
       {
        get {return evenNumbers;}
        set {evenNumbers = value;}
       }
       public List<int> OddNumbers 
       {get {return oddNumbers;}
       set{oddNumbers= value;}
       }
        public Wrapper (List<int> evenNumbers , List<int> oddNumbers)
        {
            this.evenNumbers = evenNumbers;
            this.oddNumbers= oddNumbers;

        }
        
    }
}
