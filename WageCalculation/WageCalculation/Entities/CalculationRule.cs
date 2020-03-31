using System;
using System.Collections.Generic;
using System.Text;

namespace WageCalculation.Entities
{
    public abstract class CalculationRule
    {
        protected abstract double Limit();
        protected abstract double PercentageAboveLimit();
        protected abstract double BasePercentage();

        public double Calculates(Worker worker)
        {
            if (worker.Salary > Limit())
            {
                return worker.Salary * PercentageAboveLimit();
            }
            return worker.Salary * BasePercentage();
        }        
    }
}
