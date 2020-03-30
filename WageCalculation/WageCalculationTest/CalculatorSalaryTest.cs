using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WageCalculation.Entities;
using WageCalculation.Enums;

namespace WageCalculationTest
{
    [TestFixture]
    public class CalculatorSalaryTest
    {
        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryBelowTheLimit()
        {
            CalculatorSalary calculator = new CalculatorSalary();
            Worker developer = new Worker
                ("Carlos", 1500.0, Role.DEVELOPER);

            double salary = calculator.CalculateSalary(developer);

            Assert.AreEqual(1500.0 * 0.9, salary, 0.00001);
        }

        [Test]
        public void ShouldCalculateSalaryForDevelopersWithSalaryAboveTheLimit()
        {
            CalculatorSalary calculator = new CalculatorSalary();
            Worker developer = new Worker
                ("Mauricio", 4000.0, Role.DEVELOPER);

            double salary = calculator.CalculateSalary(developer);

            Assert.AreEqual(4000.0 * 0.8, salary, 0.00001);
        }

        [Test]
        public void ShouldCalculateSalaryForDBAsWithSalaryBelowTheLimit()
        {
            CalculatorSalary calculator = new CalculatorSalary();
            Worker dba = new Worker
                ("Joao", 500.0, Role.DBA);

            double salary = calculator.CalculateSalary(dba);

            Assert.AreEqual(500.0 * 0.85, salary, 0.00001);
        }
    }
}
