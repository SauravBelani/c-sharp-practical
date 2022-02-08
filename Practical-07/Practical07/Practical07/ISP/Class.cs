using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.ISP
{
    class Landline : call
    {
        public void makeCall()
        {
            Console.WriteLine("Make a call");
        }
    }
    class Canon: Camera
    {
        public void captureImage()
        {
            Console.WriteLine("Capture Iamge");
        }
    }
    class PlayStation:VideoGame
    {
        public void playGame()
        {
            Console.WriteLine("Play Video Game");
        }
    }
    class SmartPhone : call, Camera, VideoGame
    {
        public void captureImage()
        {
            Console.WriteLine("Make a call");
        }

        public void makeCall()
        {
            Console.WriteLine("Capture Iamge");
        }

        public void playGame()
        {
            Console.WriteLine("Play Video Game");
        }
    }
}
