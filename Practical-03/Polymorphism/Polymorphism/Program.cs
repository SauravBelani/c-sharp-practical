using System;

namespace Polymorphism
{
    class Bird
    {
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    class Duck:Bird
    {
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird1 = new Bird();
            Duck myDuck1 = new Duck();
            myBird1.Voice();
            myDuck1.Voice();

            Bird myBird = new Duck();//upcast
            Duck myDuck = (Duck)myBird;//downcast
            myBird.Voice();
            myDuck.Voice();
        }
    }
}
