using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    public class Worker : Human
    {
        private double weekSalary;
        private double WHPD;

        public Worker(string firstName, string lastName, double weekSalary, double WHPD)
            : base(firstName, lastName)
        {
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = WHPD;
        }

        public override string LastName
        {
            get
            {
                return base.LastName;
            }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("At least 3 symbols");
                }
                base.LastName = value;
            }
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("value<=10");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.WHPD;
            }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Error value");
                }
                this.WHPD = value;
            }
        }

        private double GetSalaryPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("First Name: ").Append(this.FirstName).Append(Environment.NewLine).Append("Last Name: ").Append(this.LastName).Append(Environment.NewLine).Append(String.Format($"Week Salary: {this.WeekSalary}"))
            .Append(Environment.NewLine).Append(String.Format($"Hours per day: {this.WHPD}")).Append(Environment.NewLine).Append(String.Format($"Salary per hour: {this.GetSalaryPerHour()}"));

            return str.ToString();
        }
    }
}