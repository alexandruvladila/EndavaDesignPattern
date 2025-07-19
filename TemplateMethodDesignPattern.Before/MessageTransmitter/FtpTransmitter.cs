using System;

namespace StrategyDesignPattern.After
{
    public class FtpTransmitter : IMessageTransmitter         
    {
        public void Send(Message message)
        {
			Console.WriteLine($"Sending message on FTP.");
			Console.WriteLine($"Content message: {message.Content}");
		}
    }
}