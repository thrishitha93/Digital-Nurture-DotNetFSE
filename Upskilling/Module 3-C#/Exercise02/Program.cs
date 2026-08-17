using System;

int myNumber = 10;
Console.WriteLine("Value before: " + myNumber);

int copyOfNumber = myNumber;
copyOfNumber = 99; 

Console.WriteLine("Value after:  " + myNumber); 
Console.WriteLine("-------------------------");

int[] myArr = { 10, 20, 30 };
Console.WriteLine("Reference before: " + myArr[0]);

int[] sameArr = myArr;
sameArr[0] = 99;

Console.WriteLine("Reference after:  " + myArr[0]);