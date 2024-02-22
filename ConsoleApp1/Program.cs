using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace School
{
    class MainClass
    {
        static void Main()
        {
            List<Student> classRoom = new List<Student>();
            Basic.CreateClassRoom(classRoom);

            double averageGrade = Basic.CalculateAverageRate(classRoom);
            Console.WriteLine("The average grade of the class is: " + averageGrade);

            float averageHeight = Basic.CalculateAverageHeight(classRoom);
            Console.WriteLine(
                "The average female height of the class is;" + averageHeight + " " + "Meters"
            );

            int[] randomNumbers = { 67, 5, 4, 36, 10, 47, 94, 37, -64, 0, 3, 18 };
            Wrapper numberLists = Basic.SortNumbers(randomNumbers);

            Console.WriteLine("The even numbers are: ");
            foreach (int number in numberLists.EvenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("The odd numbers are: ");
            foreach (int number in numberLists.OddNumbers)
            {
                Console.WriteLine(number);
            }
                
        }
    }
}
