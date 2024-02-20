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

    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public float Height
    {
        get { return height; }
        set { height = value; }
    }
    public bool IsFemale
    {
        get { return isFemale; }
        set { isFemale = value; }
    }
}
