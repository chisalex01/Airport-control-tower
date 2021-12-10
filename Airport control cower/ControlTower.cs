using System;
using System.Collections.Generic;

namespace Airport_control_tower
{
    public class ControlTower : IControlTower
    {
        public List<IAirplane> airplanes = new List<IAirplane>();

        public void Register(IAirplane airplane)
        {
            airplanes.Add(airplane);
        }

        public void Request(IAirplane airplane)
        {
            airplane.Request = true;
            Permission(airplane);
        }

        public void Permission(IAirplane airplane)
        {
            int check = 0;
            foreach (IAirplane p in airplanes)
            {
                if (p.Request == true && p.Permission == true && p!= airplane) check = 1;
            }
            if (check == 0)
            {
                airplane.Permission = true;
                if (airplane.Status == "I want to land")
                    Console.WriteLine($"{airplane.Name} can land!");
                else if (airplane.Status == "I want to take off")
                    Console.WriteLine($"{airplane.Name} can take off!");
            }
            else Console.WriteLine($"Permission denied for {airplane.Name}!");
        }
    }
}
