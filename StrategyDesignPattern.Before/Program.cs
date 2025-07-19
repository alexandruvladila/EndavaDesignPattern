using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace StrategyDesignPattern.Before
{
    internal class Program
    {
        static void Main(string[] args) 
        {
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();


			switch (config["TransmitterType"])
			{
				case "Email":
					var emailTransmitter = new EmailTransmitter(config["Reciever"]);
					emailTransmitter.Send(config["Data"]);
					break;
				case "FTP":
					var ftpTransmitter = new FtpTransmitter(config["Reciever"]);
					ftpTransmitter.Send(config["Data"]);
					break;
				case "API":
					var apiTransmitter = new ApiTransmitter(config["Reciever"]);
					apiTransmitter.Send(config["Data"]);
					break;
			}


			Console.WriteLine();
			Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
