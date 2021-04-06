using System;


namespace ElevatorSystem
{
    public class Elevator
    {
        public int FloorCount { get; private set; }
        public int CurrentFloor { get; private set; }
        public bool IsMoving { get; private set; }

        private int _target;
        private int _firstfloor;


        public Elevator(int floors)
        {
            FloorCount = floors;
            _firstfloor = 1;
            CurrentFloor = _firstfloor;
        }

        public void Start(int target)
        {
            _target = target;
            IsMoving = true;

            int floor_decrement = 1;
            if (target < CurrentFloor)
            {
                floor_decrement = -1;
            }
            while (CurrentFloor != target)
            {
                PrintPosition();
                CurrentFloor = CurrentFloor + floor_decrement;
            }
            Console.WriteLine($"Target floor ({CurrentFloor}) reached!");
            IsMoving = false;
        }

        public void PrintPosition()
        {
            for (int i = _firstfloor; i <= FloorCount; i++)
            {
                if (i == CurrentFloor)
                {
                    Console.Write("[");
                }

                Console.Write(i);

                if (i == CurrentFloor)
                {
                    Console.Write("]");
                }
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}