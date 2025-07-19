namespace StrategyDesignPattern.Before
{
    public abstract class MessageTransmitter
    {
		protected IMessageBuilder _messageBuilder;
		public MessageTransmitter(string reciever)
        {
			switch (reciever)
			{
				case "DMP":
					_messageBuilder = new DMPMessageBuilder();
					
					break;

				case "MdT":
					_messageBuilder = new MTMessageBuilder();
					
					break;
			}
		}

		public abstract void Send(string data);
    }
}