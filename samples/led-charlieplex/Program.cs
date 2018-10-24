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

            var pinA = controller.OpenPin(4,PinMode.Input);
            var pinB = controller.OpenPin(5, PinMode.Input);
            var pinC = controller.OpenPin(6, PinMode.Input);

            while (true)
            {
                // led 1
                Console.WriteLine("led 1");
                Setup(controller);
                pinA.Mode = PinMode.Output;
                pinA.Write(PinValue.High);
                pinB.Write(PinValue.Low);
                Thread.Sleep(500);
                // led 2
                Console.WriteLine("led 2");
                Setup(controller);
                pinA.Write(PinValue.Low);
                pinB.Write(PinValue.High);
                Thread.Sleep(500);
                // led 3
                Console.WriteLine("led 3");
                Setup(controller);
                pinA.Write(PinValue.Low);
                pinC.Mode = PinMode.Output;
                pinB.Write(PinValue.High);
                pinC.Write(PinValue.Low);
                Thread.Sleep(500);
            }
        }

        private static void Setup(GpioController controller)
        {
            foreach (var pin in controller.OpenPins)
            {
                pin.Mode = PinMode.Input;
            }
        }
    }
}
