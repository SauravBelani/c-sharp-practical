using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.DIP
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Send Message with Email service");
        }
    }
    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Send Message with SMS service");
        }
    }
    public class Notification
    {
        public void DoNotify(IMessenger pMessenger)
        {
            pMessenger.SendMessage();
        }
    }
}
