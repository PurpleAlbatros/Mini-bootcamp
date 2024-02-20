using System;
using System.Collections;
using System.Runtime.CompilerServices;
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
        }
    }
}
