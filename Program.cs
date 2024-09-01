using classes_01;

// STRUCTS

// 1. basic concept

// Person person01;
// person01.name = "John";
// person01.age = 23; 

// 2. using structs in a function

// static Person ReturnPerson()
// {
//     Person person;
//     System.Console.WriteLine("Enter your name.");
//     person.name = Console.ReadLine() ?? "";
    
//     System.Console.WriteLine("Enter your age.");
//     person.age = Convert.ToInt32(Console.ReadLine());

//     return person;
// }

// Person person02 = ReturnPerson();

// System.Console.WriteLine($"{person02.name} - {person02.age}");

// 3. constructors

static Person ReturnPerson()
{
    System.Console.WriteLine("Enter your name.");
    string name = Console.ReadLine() ?? "";
    
    System.Console.WriteLine("Enter your age.");
    int age = Convert.ToInt32(Console.ReadLine());

    return new Person(name, age);
}

Person person02 = ReturnPerson();

System.Console.WriteLine($"{person02.name} - {person02.age}");
