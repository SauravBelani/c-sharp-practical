using System;

namespace Inheritance
{
    class Sponsor
    {
        protected string owner = "Rakuteen";
    }
    class Team:Sponsor
    {
        private string teamName="myTeam";
        public string Printinfo()
        {
            return "Owner: "+owner+",\nTeam Name: "+teamName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            Console.WriteLine(t.Printinfo());
        }
    }
}
