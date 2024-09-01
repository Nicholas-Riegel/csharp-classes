using System;

namespace classes_01;

public class PersonClass
{
    // fields
    private string name = string.Empty;
    private int age;

    // properties

    // public string Name { get => name; set => name = value; }
    // public int Age { get => age; set => age = value; }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            // name = value;
            name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";
        }
    }

    
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            // age = value;
            age = value >= 0 && value < 150 ? value : -1;

        }
    }

     
    public PersonClass(string name, int age)
    {
        // this.name = name;
        // this.age = age;
        Name = name;
        Age = age;
    }

    // public void SetName(string name)
    // {
    //     this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
    // }

    // public string GetName() 
    // {
    //     return name;
    // }

    // public void SetAge(int age)
    // {
    //     this.age = age >= 0 && age < 150 ? age : -1;
    // }

    // public int GetAge()
    // {
    //     return age;
    // }

    public string ReturnDetails()
    {
        // return $"Name: {name}\nAge: {age}.";
        return $"Name: {Name}\nAge: {Age}.";
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAge: {Age}.";
    }
}

