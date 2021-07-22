
namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;
        public EmailAlert()
        {
            this.emailSent = false;
        }
        void IAlerter.alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this.emailSent = true;
            }
        }
    }
}