namespace WageCalculation.Entities
{
    public class CalculatorSalary
    {
        public double CalculateSalary(Worker worker)
        {
            return worker.Role.Rule.Calculates(worker);
        }
        
    }
}
