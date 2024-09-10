// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your lastname:");
string userLastName = Console.ReadLine();
if (userGender == 'm')
{
    Console.WriteLine($"Hello, Mr. {userLastName}!");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Hello, Ms. {userLastName}!");
}

else
{
    Console.WriteLine($"Welcome {userLastName}!");
}