using System;

namespace StrategyDesignPattern.After
{
    public class EmailTransmitter : IMessageTransmitter
    {
        public void Send(Message message)
        {
			Console.WriteLine($"Sending message by email.");
			Console.WriteLine($"Email message: {message.Content}");
		}
    }
}   