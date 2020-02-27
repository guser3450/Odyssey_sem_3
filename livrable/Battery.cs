using System;
using System.Collections.Generic;

namespace livrable
{
    public class Battery
    {
        
        public int input_user;
        public int nb_column;  
        public int nb_basement;
        public int id;
        public int nb_floor;
        public int CallButton;
        public string direction;
        public List<Column> columnList;
        public List<int> floorList;
        public List<int> input_userList;
        public Battery(int input_user, int nb_column, int nb_basement, int id, int nb_floor, int CallButton, string direction)//constructor
        {
            this.input_user = input_user;
            this.direction = direction;
            this.CallButton = CallButton;
            this.nb_floor = nb_floor;
            this.id = id;
            this.nb_basement = nb_basement;
            this.nb_column = nb_column;
            this.columnList = new List<Column>(); 
            this.floorList = new List<int>();    
            this.input_userList = new List<int>();                

            for (var i = 1; i <= nb_floor; i++){
                floorList.Add(i);
            }
            // pour le modifer juste a faire new columnList(...)
            for (var j = 1; j <= 1; j++){
                columnList.Add(new Column(1, A, 5, 20, 1, 1, ""));// I don't have my basement column yet
            }
            for (var j = 1; j <= 1; j++){
                columnList.Add(new Column(1, B, 5, 40, 21, 1, ""));//the elevator will go up until the minFloor 
            }
            for (var j = 1; j <= 1; j++){
                columnList.Add(new Column(1, C, 5, 60, 41, 1, ""));
            }
            for (var j = 1; j <= 1; j++){
                columnList.Add(new Column(1, D, 5, 60, 41, 1, ""));
        }
        }

        // public int RequestFloor(int nb_floor, )
        // {
        //     for(var i = 1; i <= nb_floor; i++){
        //         if(i != 1){
        //             var callButton = new CallButton("DOWN", i);
        //             this.CallButtonList.push(callButton);
        //         }
        //         if(i != nb_floor){
        //             var callButton = new CallButton("UP", i);
        //             this.CallButtonList.push(callButton)
        //         }
        // }


        // public int ControlePanel(int nb_floor, int input_user)
        // {
        //     for(var i = 0; i < nb_floor; i++)
        //     {
        //     Console.WriteLine(floorList, "floor"+i); //print the actual panel
        //         if (input_user == floorList[i])
        //         {
        //             return floorList[i];
        //         }
        //     }
            
        // }


        public int AssignElevator(int nb_floor, string direction, int input_user, Class Column)
        {
            for(var i = 0; i < nb_floor; i++)
            {
            Console.WriteLine(floorList, "floor"+i); //print the actual panel
                if (input_user == floorList[i])
                {
                    return floorList[i];
                }
                foreach (floorList[i] )*********************
                {
                    if (floorList[i] == columnList[minFloor <= maxFloor] )*************************
                    {
                        return Column;//return the column with the value of floorList[i]
                    }
                    foreach (Column.elevatorList)
                    {
                        for (var x = 0; x < this.elevatorList.length; x++) //at this point am in ColumnX/elevatorList/elevators
                        {
                            if (Column.elevator_floor == 0){
                                if (var E = Column.elevatorList.length == E <=2)
                                {
                                    Console.WriteLine(Column.elevatorList.elevator Math.Min(id), "Best elevator");******************
                                }
                            } 
                            else if (elevator_direction == "DOWN")
                            {
                                return Math.min(elevator_floor);
                            }
                        }
                    }
                }
            return elevator; //The best elevator is returned for the floor clicked
            }
        }


        public int RequestElevator(string elevator_direction, int elevator_floor, int floor, Class CallButton, int elevatorList, Class Column)
        {
            if (floor == columnList[minFloor <= maxFloor])
            {
                return Column; 
            }
            for (var i = 0; i < this.elevatorList.length; i++)
            {
                if (elevator_direction == "DOWN" && floor < elevator_floor)
                {
                    return elevator;*********************** //faire la list daction pour les rajouter
                }
                else if (elevator_direction == "")
                {
                    for (var x = 0; x < elevatorList.length; x++)
                    {
                        var x = floor - elevator_floor;
                        if(Math.Abs(x) )
                        {
                            if ()
                        }

                    }
                    return elevator; 
                }
            }
        }
    }
}