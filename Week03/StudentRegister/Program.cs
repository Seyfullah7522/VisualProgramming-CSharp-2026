
using System;

/// <summary>
/// Represents a person.
/// </summary>
abstract class Person
{
    /// <summary>
    /// Gets or sets the person's name.
    /// </summary>
    public string Name { get; set; }

    protected int PersonId;

    /// <summary>
    /// Initializes a person with a name and ID.
    /// </summary>
    public Person(string name, int personId)
    {
        Name = name;
        PersonId = personId;
    }

    /// <summary>
    /// Displays information about the person.
    /// </summary>
    public abstract void Describe();
}

/// <summary>
/// Represents a student.
/// </summary>
class Student : Person
{
    private int mark;

    /// <summary>
    /// Gets or sets the student's mark (0-100).
    /// </summary>
    public int Mark
    {
        get { return mark; }
        set
        {
            if (value >= 0 && value <= 100)
                mark = value;
            else
                throw new ArgumentException("Mark must be between 0 and 100.");
        }
    }

    /// <summary>
    /// Initializes a student.
    /// </summary>
    public Student(string name, int personId) : base(name, personId)
    {
        Mark = 0;
    }

    /// <summary>
    /// Displays the student's information.
    /// </summary>
    public override void Describe()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student ID: " + PersonId);
        Console.WriteLine("Student Mark: " + Mark);
    }

    /// <summary>
    /// Delegate for mark notification messages.
    /// </summary>
    public delegate void MarkHandler(string msg);

    /// <summary>
    /// Occurs when a student's mark is added.
    /// </summary>
    public event MarkHandler OnMarkAdded;

    /// <summary>
    /// Adds a new mark and raises the notification event.
    /// </summary>
    public void AddMark(int newMark)
    {
        Mark = newMark;
        OnMarkAdded?.Invoke("A new mark was added for " + Name);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("John", 101);
        Student student2 = new Student("Sarah", 102);

        student1.OnMarkAdded += ShowMessage;
        student2.OnMarkAdded += ShowMessage;

        student1.AddMark(85);
        student2.AddMark(92);

        Console.WriteLine("\n===== STUDENT REGISTER =====");

        student1.Describe();
        Console.WriteLine();
        student2.Describe();
    }

    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}
