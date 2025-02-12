namespace WindowsFormsApp1
{
    internal class Beads : Transport
    {
        public Beads()
        {
            Cost = 15;
            MaxVolume = 20;
        }

        public override double CalculateTransportationCost(double weight, double volume)
        {
            return (double)(weight * 0.5 + volume * 0.8);
        }

        public override bool CanHandleCondition(string condition)
        {
            if (condition == "Амортизація" || condition == "Охолодження")
            {

                return true;

            }
            return false;
        }
    }
}
