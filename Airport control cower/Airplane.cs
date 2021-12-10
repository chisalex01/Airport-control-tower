using System;

namespace Airport_control_tower
{
    public class Airplane : IAirplane
    {
        public IControlTower Tower { get; set; }
        public string Status { get; set; } = "No request";
        public string Name { get; set; }
        public bool Request { get; set; } = false;
        public bool Permission { get; set; } = false;

        public Airplane(string name, IControlTower tower)
        {
            this.Name = name;
            Tower = tower;
            Tower.Register(this);
        }

        public void Landing()
        {
            if (this.Permission == true)
            {
                Console.WriteLine($"{this.Name} is landing!");
                this.Request = false;
                this.Permission = false;
            }
        }

        public void TakingOff()
        {
            if (this.Permission == true)
            {
                Console.WriteLine($"{this.Name} is taking off!");
                this.Request = false;
                this.Permission = false;
            }
        }

        public void RequestLanding()
        {
            this.Status = "I want to land";
            Tower.Request(this);
        }

        public void RequestTakeOff()
        {
            this.Status = "I want to take off";
            Tower.Request(this);
        }
    }
}
