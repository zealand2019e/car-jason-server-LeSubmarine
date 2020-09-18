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
            EchoClient.EchoClient echoClient = new EchoClient.EchoClient();
            Car newCar = ConsoleInquiries.GetCarObj();
            string jsonCar = JsonConvert.SerializeObject(newCar);
            echoClient.Write(jsonCar);
        }
    }
}
