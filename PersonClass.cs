using System;

namespace classes_01;

public class PersonClass
{
    public string? name;
    public int age;

    // can give it more than one constructor (overloading)
    public PersonClass()
    {
    }
    public PersonClass(string name)
    {
        this.name = name;
        this.age = -1;

    }
    public PersonClass(int age)
    {
        this.name = "";
        this.age = age;
    }
    public PersonClass(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
