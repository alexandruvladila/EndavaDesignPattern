using System;

namespace StrategyDesignPattern.After
{
    public class MTMessageBuilder : MessageBuilder
	{
		protected override string Name => "Médecine du travail";

		protected override void CheckForMandatoryFields(string data)
		{
			Console.WriteLine($"MessageBuilder: Check for MdT mandatory fields");
		}
	
		protected override void FormatMessage(string data)
		{
			Console.WriteLine($"MessageBuilder: Format MdT JSON message");
		}

		protected override void AddLogo()
		{
			Console.WriteLine($"MessageBuilder: Add MdT logo");
		}

	}
}