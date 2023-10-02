using System;

interface IVehicle
{
    void Start();
    void Stop();
    double Speed { get; set; }
    double FuelLevel { get; set; }
}

interface IDriveable
{
    void Accelerate();
    void Brake();
    void Turn();
}

interface ICargoCarrier
{
    void LoadCargo();
    void UnloadCargo();
}

interface IElectricVehicle
{
    void ChargeBattery();
    double BatteryLevel { get; set; }
}

interface ISelfDriving
{
    void EnableAutopilot();
    void DisableAutopilot();
}

class Car : IVehicle, IDriveable, ISelfDriving
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public double Speed { get; set; }

    public double FuelLevel { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Car accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Car braking.");
    }

    public void Turn()
    {
        Console.WriteLine("Car turning.");
    }

    public void EnableAutopilot()
    {
        Console.WriteLine("Autopilot enabled.");
    }

    public void DisableAutopilot()
    {
        Console.WriteLine("Autopilot disabled.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Start();
        car.Accelerate();
        car.EnableAutopilot();
        car.DisableAutopilot();
        car.Brake();
        car.Stop();
    }
}
