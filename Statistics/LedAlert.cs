
namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows;
        public LEDAlert()
        {
            this.ledGlows = false;
        }
        void IAlerter.alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this.ledGlows = true;
            }
        }
    }
}