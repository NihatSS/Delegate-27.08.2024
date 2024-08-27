﻿namespace Delegate_Task;

internal class People
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public People(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} {Surname} {Age}";
    }
}
