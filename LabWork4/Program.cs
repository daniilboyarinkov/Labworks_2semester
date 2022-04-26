using LabWork4;

var test1 = new Test1(
    "Дудь", 
    "Юрий", 
    "Александрович", 
    35, 
    "Журналист", 
    8, 
    75000);

var test2 = new Test2(
    "Ротерьер", 
    "Сергей", 
    "Михайлович", 
    21, 
    "Барсик", 
    2, 
    8);

ConsoleReporting consoleReporing = new();

ConsoleReporting.Parse(new List<object> { test1, test2 });

public class Test1
{
    public string FirstName { get; set; } = string.Empty;
    public string SecondName { get; set; } = string.Empty;
    private string ThirdName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public int Experience { get; set; }

    [NotPrintableAttribute]
    public int Salary { get; set; }

    public Test1() { }
    public Test1(string FirstName, string SecondName, string ThirdName, int Age, string Position, int Experience, int Salary)
    {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.ThirdName = ThirdName;
        this.Age = Age;
        this.Position = Position;
        this.Experience = Experience;
        this.Salary = Salary;
    }
}

[HorizontalAlignment]
public class Test2
{
    public string FirstName { get; set; } = string.Empty;
    public string SecondName { get; set; } = string.Empty;
    private string ThirdName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string PetName { get; set; } = string.Empty;
    public int Experience { get; set; }

    [NotPrintableAttribute]
    public int OverAllRating { get; set; }
    public Test2() { }
    public Test2(string FirstName, string SecondName, string ThirdName, int Age, string PetName, int Experience, int OverAllRating)
    {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.ThirdName = ThirdName;
        this.Age = Age;
        this.PetName = PetName;
        this.Experience = Experience;
        this.OverAllRating = OverAllRating;
    }
}


