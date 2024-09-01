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
//     Console.WriteLine("Enter your name.");
//     person.name = Console.ReadLine() ?? "";
    
//     Console.WriteLine("Enter your age.");
//     person.age = Convert.ToInt32(Console.ReadLine());

//     return person;
// }

// PersonStruct person02 = ReturnPerson();

// Console.WriteLine($"{person02.name} - {person02.age}");

// 3. constructors

// static PersonStruct ReturnPerson()
// {
//     Console.WriteLine("Enter your name.");
//     string name = Console.ReadLine() ?? "";
    
//     Console.WriteLine("Enter your age.");
//     int age = Convert.ToInt32(Console.ReadLine());

//     return new PersonStruct(name, age);
// }

// PersonStruct person02 = ReturnPerson();

// Console.WriteLine($"{person02.name} - {person02.age}");

// CLASSES

// Console.WriteLine("Enter your name.");
// string name = Console.ReadLine() ?? "";

// Console.WriteLine("Enter your age.");
// int age = Convert.ToInt32(Console.ReadLine());

// PersonClass person03 = new (name, age);

// if (!string.IsNullOrEmpty(person03.name))
// {
//     Console.WriteLine($"Name: {person03.name}");
// }

// if (person03.age > -1)
// {
//     Console.WriteLine($"Age: {person03.age}");
// }

// CLASS FUNCTIONS
// PersonClass person = new("Aba", 34);

// // person.name = "Harry";
// // person.age = 4;
// person.SetName("Harry");
// person.SetAge(4);

// Console.WriteLine(person.ReturnDetails());

// CLASS PROPERTIES
PersonClass person = new("Aba", 34);

person.Name = "Harry"; // don't have to specify get or set

// Console.WriteLine(person.ReturnDetails());
Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");