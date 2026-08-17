
using System;

CheckType("Hello");
CheckType(42);
CheckType(true);

void CheckType(object obj)
{
    if (obj is string text)
    {
        Console.WriteLine("It is a string: " + text);
    }

    string message = obj switch
    {
        int num => "It is an integer: " + num,
        bool boolean => "It is a boolean: " + boolean,
        _ => "Unknown type"
    };

    Console.WriteLine("Switch result: " + message);
    Console.WriteLine("-------------------------");
}