using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace StrategyDesignPattern.After
{
    internal class Program
    {
        static void Main(string[] args) 
        {
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();


			var builders = new Dictionary<string, IMessageBuilder>
			{
				{ "DMP", new DMPMessageBuilder() },
				{ "MdT", new MTMessageBuilder() }
			};

			var transmitters = new Dictionary<string, IMessageTransmitter>
            {
                { "Email", new EmailTransmitter() },
                { "FTP", new FtpTransmitter() },
                { "API", new ApiTransmitter() }
            };

			// Create reciever based on request configuration
			var reciever = builders[config["Reciever"]];
			// Create transmitter based on request configuration
			var transmitterType = transmitters[config["TransmitterType"]];


			var processor = new MessageProcessor(reciever, transmitterType);
			processor.Send(config["Data"]);


            Console.WriteLine();
			Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
