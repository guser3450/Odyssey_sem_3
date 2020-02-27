using System;
using System.Collections.Generic;

namespace livrable
{
    public class CallButton
    {
        public int id;
        public int floor;
        public string direction;
        public CallButton(int id, int floor, string direction)
        {
            this.id = id;
            this.floor = floor;
            this.direction = direction;

            for(var i = 0; i < nb_elevator; i = i++){
            console.WriteLine("Callbutton");
            this.elevatorList.Add(new Elevator("elevator"+i, 2, 'UP', 'IDLE'));
            }
        }
    }
}