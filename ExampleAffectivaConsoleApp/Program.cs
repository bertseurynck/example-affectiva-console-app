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

            PhotoDetector detector = new PhotoDetector(1, FaceDetectorMode.LARGE_FACES);

            String licensePath = @"D:\ExampleAffectivaConsoleApp\AffectivaLicense\sdk.license";
            detector.setLicensePath(licensePath);

            String classifierPath=@"C:\Program Files\Affectiva\Affdex SDK\data";
            detector.setClassifierPath(classifierPath);

            detector.start();
            //cwkTODO process
            detector.stop();
            detector.reset();

            // So the console window does not close immediately
            Console.ReadLine();
        }
    }
}
