using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical07.ISP
{
    interface call
    {
        void makeCall();
    }
    interface Camera
    {
        void captureImage();
    }
    interface VideoGame
    {
        void playGame();
    }
}
