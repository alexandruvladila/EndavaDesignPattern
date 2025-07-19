using System;

namespace StrategyDesignPattern.After
{
	public abstract class MessageBuilder
	{
		protected abstract string Name { get;}
	
		public Message Build(string data)
		{
			Sanitize(data);
			CheckForMandatoryFields(data);
			ValidateDataIntegrity(data);
			FormatMessage(data);
			AddLogo();

			return new Message { Content = $"{Name} message built from '{data}'" };
		}

		protected void Sanitize(string data)
		{
			Console.WriteLine($"MessageBuilder: Sanitizing data");
		}

		protected abstract void CheckForMandatoryFields(string data);

		protected virtual void ValidateDataIntegrity(string data)
		{
			Console.WriteLine($"MessageBuilder: Validate data integrity");
		}

		protected abstract void FormatMessage(string data);

		protected abstract void AddLogo();

	}
}