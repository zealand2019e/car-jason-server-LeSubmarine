using System;
using ModelLib;
using Newtonsoft.Json;
using OneLineCalc;

namespace CarJsonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            using (EchoClient.EchoClient echoClient = new EchoClient.EchoClient())
            {
                while (true)
                {
                    //Car newCar = ConsoleInquiries.GetCarObj();
                    //string jsonCar = JsonConvert.SerializeObject(newCar);
                    //echoClient.Write(jsonCar);
                    echoClient.Write("Start");
                    echoClient.Write("Car object");
                    echoClient.Write("Color: " + ConsoleInquiries.GetCarColor());
                    echoClient.Write("Model: " + ConsoleInquiries.GetCarModel());
                    echoClient.Write("RegNr: " + ConsoleInquiries.GetRegNr());
                    echoClient.Write("Stop");
                }
            }
        }
    }
}
