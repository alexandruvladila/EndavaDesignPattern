namespace StrategyDesignPattern.After
{
    public class MessageProcessor
    {
        private readonly IMessageTransmitter _transmitter;
		private readonly IMessageBuilder _messageBuilder;

		public MessageProcessor(IMessageBuilder messageBuilder, IMessageTransmitter transmitter)
        {
			_transmitter = transmitter;
			_messageBuilder = messageBuilder;
        }

        public void Send(string data)
        {
            var message = _messageBuilder.Build(data);

			_transmitter.Send(message);
        }
    }
}       