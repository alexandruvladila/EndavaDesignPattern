using System;

namespace StrategyDesignPattern.After
{
    public class ApiTransmitter : IMessageTransmitter
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Sending message using API.");
			Console.WriteLine($"Payload: '{message.Content}'");
		}
    }
}