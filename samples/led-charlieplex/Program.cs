using System;
using System.Devices.Gpio;

namespace led_charlieplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var controller = new GpioController(PinNumberingScheme.Gpio);
        }
    }
}
