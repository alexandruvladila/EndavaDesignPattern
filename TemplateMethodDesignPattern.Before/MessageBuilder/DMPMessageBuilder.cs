using System;

namespace StrategyDesignPattern.After
{
    public class DMPMessageBuilder : IMessageBuilder
	{
        public Message Build(string data)
        {
			Console.WriteLine($"MessageBuilder: Sanitizing data");
			Console.WriteLine($"MessageBuilder: Check for DMP mandatory fields");
			Console.WriteLine($"MessageBuilder: Validate data integrity");
			Console.WriteLine($"MessageBuilder: Format HL7 message");
			Console.WriteLine($"MessageBuilder: Add DMP logo");

			return new Message { Content = $"DMP message built from '{data}'" };
		}
    }
}   