using System;

namespace StrategyDesignPattern.Before
{
    public class FtpTransmitter : MessageTransmitter         
    {
        public FtpTransmitter(string reciever) :
            base(reciever)
        {
        }

		public override void Send(string data)
        {
			var builder = _messageBuilder.Build(data);

			Console.WriteLine($"Sending message on FTP.");
			Console.WriteLine($"Content message: {builder.Content}");
		}
    }
}