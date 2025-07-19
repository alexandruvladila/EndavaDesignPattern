using System;

namespace StrategyDesignPattern.Before
{
    public class EmailTransmitter : MessageTransmitter
    {
		public EmailTransmitter(string reciever) :
			base(reciever)
		{
		}

		public override void Send(string data)
		{
			var builder = _messageBuilder.Build(data);

			Console.WriteLine($"Sending message by email.");
			Console.WriteLine($"Email message: {builder.Content}");
		}
    }
}   