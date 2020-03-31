using WageCalculation.Entities;

namespace WageCalculation.Interfaces
{
    public interface ICalculationRule
    {
        double Calculates(Worker worker);
    }
}
