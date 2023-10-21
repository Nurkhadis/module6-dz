using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30
        };

        string personInfo = PersonUtility.GetPersonInfo(person);
        Console.WriteLine(personInfo);
    }
}
