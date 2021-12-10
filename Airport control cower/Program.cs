using System;

namespace Airport_control_tower
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tower = new ControlTower();
            var a1 = new Airplane("Boeing", tower);
            var a2 = new Airplane("Learjet", tower);
            var a3 = new Airplane("Airbus", tower);

            a1.RequestLanding();
            a2.RequestLanding();
            a3.RequestLanding();
            a1.Landing();
            a3.RequestLanding();
            a2.Landing();
            a3.Landing();
            
        }
    }
}
