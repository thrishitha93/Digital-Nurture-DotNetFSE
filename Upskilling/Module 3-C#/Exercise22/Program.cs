using System;

(int id, string name) = GetUser();

Console.WriteLine("ID: " + id);
Console.WriteLine("Name: " + name);

(int, string) GetUser()
{
    return (101, "Alice");
}