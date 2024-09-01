using System;

namespace classes_01;

public class PersonClass
{
    string name;
    int age;

    public PersonClass(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void SetName(string name)
    {
        this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
    }

    public string GetName() 
    {
        return name;
    }

    public void SetAge(int age)
    {
        this.age = age >= 0 && age < 150 ? age : -1;
    }

    public int GetAge()
    {
        return age;
    }

    public string ReturnDetails()
    {
        return $"Name: {name}\nAge: {age}.";
    }
}
