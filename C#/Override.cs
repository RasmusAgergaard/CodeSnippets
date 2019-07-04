using System;

namespace OverrideExample
{
    public class Employee
    {
        public string name;
        protected decimal basepay; //defined as protected, so that it may be accessed only by this class and derived classes

        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }

        public virtual decimal CalculatePay() //Declared virtual so it can be overridden
        {
            return basepay;
        }
    }

    public class SalesEmployee : Employee
    {
        private decimal salesBonus;

        public SalesEmployee(string name, decimal basepay, decimal salesBonus) : base(name, basepay)
        {
            this.salesBonus = salesBonus;
        }

        //Override the CalculatePay method to take bonus into account
        public override decimal CalculatePay()
        {
            return basepay + salesBonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Bill Gates", 2000);
            var employee2 = new SalesEmployee("Phill Gates", 1100, 200);

            Console.WriteLine($"{employee1.name}, Pay: {employee1.CalculatePay()}");    //Output: Bill Gates, Pay: 2000
            Console.WriteLine($"{employee2.name}, Pay: {employee2.CalculatePay()}");    //Output: Phill Gates, Pay: 1300

        }
    }
}
