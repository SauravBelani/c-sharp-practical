using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.SRP
{
    public interface IAddOperation
    {
        string AddEmployeeDetails(AddEmployee em);
    }
    public class AddEmployee : IAddOperation
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public AddEmployee(int Employee_Id, string Employee_Name)
        {
            this.Employee_Id = Employee_Id;
            this.Employee_Name = Employee_Name;
        }
        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public string AddEmployeeDetails(AddEmployee em)
        {
            // Insert into employee table.
            return $"Employee {em.Employee_Name} Added Successfully...";
        }
    }
    public class ReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(AddEmployee em)
        {
            Console.WriteLine($"Report generating of {em.Employee_Name}.");
        }
    }
}
