namespace WageCalculation.Entities
{
    public class FifteenOrTwentyPercent : CalculationRule
    {
        protected override double BasePercentage()
        {
            return 0.85;
        }

        protected override double PercentageAboveLimit()
        {
            return 0.75;
        }

        protected override double Limit()
        {
            return 2500.0;
        }        
    }
}
