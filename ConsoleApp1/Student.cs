public class Student
{
    private int grade;
    private float height;
    private string name;

    private bool isFemale;

    public Student(int grade, float height, string name, bool isFemale)
    {
        this.grade = grade;
        this.height = height;
        this.name = name;
        this.isFemale = isFemale;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
