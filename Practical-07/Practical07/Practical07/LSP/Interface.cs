using Practical07.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.LSP
{
    public interface IProject
    {
        string GetProjectDetails(int employeeId);
    }
    public interface IEmployee
    {
        string ShowEmployeeDetails(AddEmployee e);
    }
}
