using System;
using System.Collections.Generic;

namespace livrable
{       
    public class Column
    {
        public int user_floor;
        public int nb_elevator;
        public int elevator_floor;
        public string elevator_direction;
        public int id;
        public int maxFloor;
        public int minFloor;
        public List<Elevator> elevatorList;

        public Column(int user_floor, int id, int nb_elevator, int maxFloor, int minFloor, int elevator_floor, string elevator_direction) //constructor
        {
            this.user_floor = user_floor;
            this.maxFloor = maxFloor;
            this.minFloor = minFloor;
            this.id = id;
            this.nb_elevator = nb_elevator; 
            this.elevator_floor = elevator_floor;
            this.elevator_direction = elevator_direction;
            this.elevatorList = new List<Elevator>();
            List<int> floorList = new List<int>(); 



            




            //my 5 elevator in my column 1
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(1, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(2, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(3, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(4, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(5, 1, ""));
            }

            //elevator in column 2
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(6, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(7, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(8, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(9, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(10, 1, ""));
            }

            //elevator in column 3
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(11, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(12, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(13, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(14, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(15, 1, ""));
            }

            //elevator in column 4 
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(16, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(17, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(18, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(19, 1, ""));
            }
            for (var j = 1; j <= 1; j++)
            {
                elevatorList.Add(new Elevator(20, 1, ""));
            }
        }

        public int FindElevator(int nb_elevator, string elevator_direction)
        {
            if (RequestFloor == )
        }
    }
}