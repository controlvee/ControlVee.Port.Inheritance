using System;

namespace ControlVee.Port.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer eng = new Engineer();
            Console.WriteLine($"Employee Name: {eng.GetName()} \nSalary: {eng.GetSalary()} \nHire Date: {eng.HiredDate()}");
            Console.Read();

            SoftwareEngineer sEng = new SoftwareEngineer();
            Console.WriteLine($"Employee Name: {sEng.GetName()} \nSalary: {sEng.GetSalary()} \nHire Date: {sEng.HiredDate()}");
            Console.Read();
        }
    }

    class Employee
    {
        string name;
        string salary;
        string hireDate;

        public Employee()
        {

        }

        public Employee(string name, string salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }

        public virtual string GetName()
        {
            return name;
        }
        
        public virtual string GetSalary()
        {
            return salary;
        }

        // Should be GetHiredDate() in my opinion (verb/noun).
        public virtual string HiredDate()
        {
            return hireDate;
        }
    }

    class Engineer : Employee
    {
        string schoolAttended;

        public Engineer() : base("Adam G", "100,000", "01.02.2021")
        {

        }

        public Engineer(string schoolAttended) : base("Adam G", "100,000", "01.02.2021")
        {
            this.schoolAttended = schoolAttended;
        }
    }

    class SoftwareEngineer : Engineer
    {
        public SoftwareEngineer()
        {

        }

        public override string GetSalary()
        {
            return "Sorry this employee's salary is private.";
        }
    }
}
