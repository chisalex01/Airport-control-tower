namespace Airport_control_tower
{
    public interface IAirplane
    {
        public string Status { get; set; }
        public string Name { get; set; }
        public bool Request { get; set; }
        public bool Permission { get; set; }
        public void Landing();
        public void TakingOff();
        public void RequestLanding();
        public void RequestTakeOff();
    }
}
