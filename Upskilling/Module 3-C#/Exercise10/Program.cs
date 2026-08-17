using System;

Car car1 = new Car();
car1.DisplayInfo();

Car car2 = new Car("Toyota", "Corolla", 2022);
car2.DisplayInfo();

class Car
{
    public string Make;
    public string Model;
    public int Year;

    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Car: " + Year + " " + Make + " " + Model);
    }
}