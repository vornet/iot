using System;
using System.Devices.Gpio;
using System.Threading;

namespace led_charlieplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var controller = new GpioController(PinNumberingScheme.Gpio);

            var pinA = controller.OpenPin(4,PinMode.Output);
            var pinB = controller.OpenPin(5, PinMode.Output);
            var pinC = controller.OpenPin(6, PinMode.Input);

            while (true)
            {
                // led 1
                Console.WriteLine("led 1");
                pinA.Mode = PinMode.Output;
                pinC.Mode = PinMode.Input;
                pinA.Write(PinValue.High);
                pinB.Write(PinValue.Low);
                Thread.Sleep(500);
                // led 2
                Console.WriteLine("led 2");
                pinA.Write(PinValue.Low);
                pinB.Write(PinValue.High);
                Thread.Sleep(500);
                // led 3
                Console.WriteLine("led 3");
                pinA.Write(PinValue.Low);
                pinA.Mode = PinMode.Input;
                pinC.Mode = PinMode.Output;
                pinB.Write(PinValue.High);
                pinC.Write(PinValue.Low);
                Thread.Sleep(500);
            }
        }
    }
}
