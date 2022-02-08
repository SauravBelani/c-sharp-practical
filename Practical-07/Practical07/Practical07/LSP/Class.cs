using Practical07.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.LSP
{
    public class permanentEmployee : IProject,IEmployee
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Permanent Employee Project Details";
        }
        public string ShowEmployeeDetails(AddEmployee e)
        {
            return $"Employee Id: {e.Employee_Id}, Employee Name: {e.Employee_Name}";
        }
    }
    public class temporaryEmployee : IProject
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Temporary Employee Project Details";
        }
    }
}
