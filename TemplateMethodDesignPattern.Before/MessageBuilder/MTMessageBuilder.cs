using System;

namespace StrategyDesignPattern.After
{
    public class MTMessageBuilder : IMessageBuilder
	{
        public Message Build(string data)
		{
			Console.WriteLine($"MessageBuilder: Sanitizing data");
			Console.WriteLine($"MessageBuilder: Check for MdT mandatory fields");
			Console.WriteLine($"MessageBuilder: Validate data integrity");
			Console.WriteLine($"MessageBuilder: Format MdT message");
			Console.WriteLine($"MessageBuilder: Add MdT logo");

			return new Message { Content = $"Médecine du travail message built from '{data}'" };
		}
    }
}