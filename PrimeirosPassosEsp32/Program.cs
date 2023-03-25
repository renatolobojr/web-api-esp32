using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;

namespace PrimeirosPassosEsp32
{
    public class Program
    {
        public static GpioPin ledHeartBeat;

        public static void Main()
        {
            Init();

            while(true)
            {
                Run();
                Heartbeat();
            }

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }

        public static void Init()
        {
            var gpioCOntroller = new GpioController();

            ledHeartBeat = gpioCOntroller.OpenPin(2, PinMode.Output);
        }

        public static void Run() 
        {
            //run
            Thread.Sleep(1000);
            Debug.WriteLine("Debugando!");            
        }

        public static void Heartbeat(int seconds = 1) 
        {            
            ledHeartBeat.Write(PinValue.High);
            Thread.Sleep(1000);
            ledHeartBeat.Write(PinValue.Low);
        }
    }
}
