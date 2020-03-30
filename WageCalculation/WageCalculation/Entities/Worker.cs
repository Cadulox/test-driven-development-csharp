using WageCalculation.Enums;

namespace WageCalculation.Entities
{
    public class Worker
    {
        public string Name { get; private set; }
        public double Salary { get; set; }
        public Role Role { get; set; }

        public Worker(string name, double salary, Role role)
        {
            Name = name;
            Salary = salary;
            Role = role;
        }
    }
}
