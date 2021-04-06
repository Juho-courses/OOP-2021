using System;

namespace ElevatorSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator(5);

            Console.WriteLine(elevator.CurrentFloor);

            // elevator.PrintPosition();

            elevator.Start(5);

            elevator.Start(4);
        }
    }
}
