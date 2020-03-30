using WageCalculation.Enums;

namespace WageCalculation.Entities
{
    public class CalculatorSalary
    {
        public double CalculateSalary(Worker worker)
        {
            if(worker.Role == Role.DEVELOPER)
            {
                if (worker.Salary > 3000)
                {
                    return worker.Salary * 0.8;
                }
                return worker.Salary * 0.9;
            }
            else
            {
                return worker.Salary * 0.85;
            }
            
        }
    }
}
