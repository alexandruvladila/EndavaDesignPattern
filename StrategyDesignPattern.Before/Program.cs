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

			MessageTransmitter transmitter = null;
			switch (config["TransmitterType"])
			{
				case "Email":
					transmitter = new EmailTransmitter(config["Reciever"]);

					break;
				case "FTP":
					transmitter = new FtpTransmitter(config["Reciever"]);
					break;
				case "API":

					transmitter = new ApiTransmitter(config["Reciever"]);
					break;
			}

			//send message
			transmitter.Send(config["Data"]);


			Console.WriteLine();
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
