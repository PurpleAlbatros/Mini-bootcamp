using System;
using System.Collections;
using System.Runtime.CompilerServices;

class MainClass
{
    static void Main()
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

        List<Student> classRoom = new List<Student>();

        classRoom.Add(john);
        classRoom.Add(jane);

        //Loops
        foreach (Student student in classRoom)
        {
            Console.WriteLine(student.Name);
        }
        for (int i = 0; i < classRoom.Count; i++)
        {
            Console.WriteLine(classRoom[0].Name);
        }
    }
}
