using System;
class Student
{
    public string name {get; set;}
    public int age {get; set;}
    public string group {get; set;}

    public Student(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }

    public void Study()
    {
        Console.WriteLine($"Студент по имени {name}, которому {age} лет, учится в группе {group}");
    }
}

class Mag: Student
{
    public Mag(string name, int age, string group): base(name, age, group) {}
    public void Def()
    {
        Console.WriteLine($"{name} готовится к защите диплома");
    }
}

class Bac: Student
{
    public Bac(string name, int age, string group): base(name, age, group) {}

    public void Pass()
    {
        Console.WriteLine($"{name} сдаёт экзамены");
    }
}
