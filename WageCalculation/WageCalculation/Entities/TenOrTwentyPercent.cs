namespace WageCalculation.Entities
{
    public class TenOrTwentyPercent : CalculationRule
    {
        protected override double BasePercentage()
        {
            return 0.9;
        }

        protected override double PercentageAboveLimit()
        {
            return 0.8;
        }

        protected override double Limit()
        {
            return 3000.0;
        }
    }
}
