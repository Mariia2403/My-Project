namespace WindowsFormsApp1
{
    abstract class Transport
    {
        public double Cost { get; protected set; }
        public double MaxWeight { get; set; }
        public double MaxVolume { get; protected set; }

        public bool CanHandleVolume(double volume)
        {
            return volume <= MaxVolume;
        }
        public abstract bool CanHandleCondition(string condition);
        
        public abstract double CalculateTransportationCost(double weight, double volume);

    }
}
