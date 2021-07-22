 using System.Collections.Generic;
 namespace Statistics{
    public class StatsAlerter
    {
        double maxThreshold;
        IAlerter[] allAlerts;
        public StatsAlerter(double maxThreshold,IAlerter[] allAlerts)
        {
            this.maxThreshold = maxThreshold;
            this.allAlerts = allAlerts;
        }
        public void checkAndAlert(List<double> numbers)
        {
            double max = StatsUtility.CalculateMaximum(numbers);
            foreach(IAlerter Alert in allAlerts )
                Alert.alert(maxThreshold, max);
        }
    }
}