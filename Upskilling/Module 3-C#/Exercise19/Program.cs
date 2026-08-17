using System;
using System.Collections.Generic;

List<string> fruits = new List<string> { "Apple", "Banana" };
fruits.Add("Cherry");
fruits.Remove("Banana");

Console.WriteLine("--- List Items ---");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> users = new Dictionary<int, string>();
users.Add(101, "Alice");
users.Add(102, "Bob");
users.Remove(101);

Console.WriteLine("\n--- Dictionary Items ---");
foreach (KeyValuePair<int, string> user in users)
{
    Console.WriteLine("ID: " + user.Key + ", Name: " + user.Value);
}