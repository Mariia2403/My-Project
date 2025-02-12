namespace WindowsFormsApp1
{
    internal class Track : Transport
    {
        public Track()
        {
            Cost = 50;
            MaxVolume = 100;
        }

        public override double CalculateTransportationCost(double weight, double volume)
        {
            return (double)(weight * 1.9 + volume * 1.9);

        }

        public override bool CanHandleCondition(string condition)
        {
            if (condition == "Амортизація" || condition == "Герметичність")
            {

                return true;

            }
            return false;
        }
    }
}
