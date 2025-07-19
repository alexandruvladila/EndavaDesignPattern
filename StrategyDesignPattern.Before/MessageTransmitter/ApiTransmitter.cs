using System;

namespace StrategyDesignPattern.Before
{
    public class ApiTransmitter : MessageTransmitter
    {
		public ApiTransmitter(string reciever) :
			base(reciever)
		{
		}

		public override void Send(string message)
		{
			var builder = _messageBuilder.Build(message);

			Console.WriteLine($"Sending message using API.");			
			Console.WriteLine($"Payload: '{builder.Content}'");
		}
    }
}