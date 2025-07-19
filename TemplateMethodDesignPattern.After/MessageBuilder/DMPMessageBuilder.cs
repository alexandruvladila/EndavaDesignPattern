using System;

namespace StrategyDesignPattern.After
{
    public class DMPMessageBuilder : MessageBuilder
	{
		protected override string Name => "DMP";
				
		protected override void CheckForMandatoryFields(string data)
		{
			Console.WriteLine($"MessageBuilder: Check for DMP mandatory fields");
		}

		protected override void ValidateDataIntegrity(string data)
		{
			base.ValidateDataIntegrity(data);
			Console.WriteLine($"MessageBuilder: Validate data integrity (DMP specific)");
		}

		protected override void FormatMessage(string data)
		{
			Console.WriteLine($"MessageBuilder: Format HL7 message");
		}

		protected override void AddLogo()
		{
			Console.WriteLine($"MessageBuilder: Add DMP logo");
		}
	}
}   