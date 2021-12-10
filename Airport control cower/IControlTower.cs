namespace Airport_control_tower
{
    public interface IControlTower
    {
        public void Register(IAirplane airplane);
        public void Permission(IAirplane airplane);
        public void Request(IAirplane airplane);
    }
}
