using Practical07.DIP;
using Practical07.ISP;
using Practical07.LSP;
using Practical07.OCP;
using Practical07.SRP;
using System;
using System.Collections.Generic;

namespace Practical07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------SRP---------------");
            AddEmployee e = new(1, "Saurav");
            Console.WriteLine(e.AddEmployeeDetails(e));
            Console.WriteLine("\n");

            Console.WriteLine("---------------OCP---------------");
            IReportGeneration rg = new CrystalReportGeneraion();
            rg.GenerateReport(e);
            Console.WriteLine("\n");

            Console.WriteLine("---------------LSP---------------");
            permanentEmployee pe = new permanentEmployee();
            Console.WriteLine(pe.ShowEmployeeDetails(e));
            Console.WriteLine(pe.GetProjectDetails(1));
            Console.WriteLine("\n");

            Console.WriteLine("---------------ISP---------------");
            SmartPhone s = new SmartPhone();
            s.captureImage();
            s.makeCall();
            s.playGame();
            Console.WriteLine("\n");

            Console.WriteLine("---------------DIP---------------");
            IMessenger m = new Email();
            m.SendMessage();
            Notification n = new();
            n.DoNotify(m);
            Console.WriteLine("\n");
        }
    }
}
