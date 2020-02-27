using System;
using System.Collections.Generic;

namespace livrable
{
    public class Elevator
    {
        public string name;
        public int floor;
        public string direction;
        public Elevator(string name, int floor, string direction)
        {
            this.name = name;
            this.floor = floor;
            this.direction = direction;
        }
    }
}