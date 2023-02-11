using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
/*Person bred = new Person("Bred");
bred.Print();

Employee ted = new Employee("Ted", "Google");

ted.Print();

class Person
{
    /*int age = 1;
    public virtual int Age
    {
        get => age;
        set { if (value > 0 && value < 110) age = value; }
    }
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void Print()
    {
        WriteLine(Name);
    }
}
class Employee:Person
{
    /*public override int Age 
    { 
        get => base.Age;
        set {if(value>17&&value<110) base.Age=value; } 
    }*/
/*public new string Name
{
    get => $"Mr./Ms.{base.Name}";
    set => base.Name = value;
}

public string Company { get; set; }
public Employee(string name,string company):base(name)
{
    Company = company;
    //base.Age = 18;
}
public new void Print()
{
    /*base.Print();
    WriteLine($"Работает в компании {Company}");
    WriteLine($"{Name} работает в компании {Company}");
}
}*/
/*Human human = new Human { Name = "Ivan" };
WriteLine(human.ToString());
object human1 = new Human { Name = "Petor" };
if (human1.GetType() == typeof(Human))
    WriteLine("Это класс Human");
if (human is Human)
    WriteLine("Это класс Human");
Clock clock = new Clock { Hours = 10, Minutes = 40, Seconds = 30 };
WriteLine(clock.ToString());
class Clock
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public override string ToString()
    {
        return $"{Hours}:{Minutes}:{Seconds}";
    }
}
class Human
{
    public string Name { get; set; }
}*/
/*try
{
    try
    {
        WriteLine("Введите имя: ");
        string? name = ReadLine();
        if(name==null|| name.Length<2)
        {
            throw new Exception("Длина имени меньше 2 символов");
        }
        else
        {
            WriteLine($"Ваше имя: {name}");
        }
    }
    catch(Exception e)
    {
        WriteLine($"Ошибка: {e.Message}");
        throw;
    }
}
catch(Exception ex)
{
    WriteLine(ex.Message);
}*/
/*try
{
    Human human1 = new Human { Name = "Ivan", Age = 17 };
}
catch(HumanException ex)
{
    WriteLine($"Ошибка: {ex.Message}");
    WriteLine($"некорректное значение: {ex.Value}");
}
class Human
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new HumanException("Призыв в армию до 18 запрещен законом",value);
            else
                age = value;
        }
    }
}
class HumanException:ArgumentException
{
    public int Value { get; }
    public HumanException(string message, int val):base(message)
    {
        Value = val;
    }
}*/
try
{
    TestClass.Method1();
}
catch(DivideByZeroException ex)
{
    WriteLine($"Catch в Main: {ex.Message}");
}
finally
{
    WriteLine("Блок finally в Main");
}
WriteLine("Конец блока Main");
class TestClass
{
    public static void Method1()
    {
        try 
        {
            Method2();
        }
        catch(IndexOutOfRangeException ex)
        {
            WriteLine($"Catch in Method1: {ex.Message}");
        }
        finally
        {
            WriteLine("Блок finally в Method1");
        }
        WriteLine("Конец метода Method1");
    }
    static void Method2()
    {
        try
        {
            int x =9;
            int y = x / 0;
        }
        finally
        {
            WriteLine("Блок Finally в Method2");
        }
        WriteLine("Конец метода Method2");
    }
}