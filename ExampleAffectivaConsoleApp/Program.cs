using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Affdex;

namespace ExampleAffectivaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Affectiva Console App");

            PhotoDetector detector = new PhotoDetector(1);

            String licensePath = @"";
            detector.setLicensePath(licensePath);

            // So the console window does not close immediately
            Console.ReadLine();
        }
    }
}
