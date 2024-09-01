using classes_01;

// STRUCTS

// 1. basic concept

// PersonStruct person01;
// person01.name = "John";
// person01.age = 23; 

// 2. using structs in a function

// static PersonStruct ReturnPerson()
// {
//     PersonStruct person;
//     System.Console.WriteLine("Enter your name.");
//     person.name = Console.ReadLine() ?? "";
    
//     System.Console.WriteLine("Enter your age.");
//     person.age = Convert.ToInt32(Console.ReadLine());

//     return person;
// }

// PersonStruct person02 = ReturnPerson();

// System.Console.WriteLine($"{person02.name} - {person02.age}");

// 3. constructors

static PersonStruct ReturnPerson()
{
    System.Console.WriteLine("Enter your name.");
    string name = Console.ReadLine() ?? "";
    
    System.Console.WriteLine("Enter your age.");
    int age = Convert.ToInt32(Console.ReadLine());

    return new PersonStruct(name, age);
}

PersonStruct person02 = ReturnPerson();

System.Console.WriteLine($"{person02.name} - {person02.age}");
