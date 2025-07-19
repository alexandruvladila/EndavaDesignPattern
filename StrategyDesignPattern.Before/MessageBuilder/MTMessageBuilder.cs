namespace StrategyDesignPattern.Before
{
    public class MTMessageBuilder  : IMessageBuilder
	{
        public Message Build(string data)
		{
			return new Message { Content = $"JSON message for MdT built from '{data}'" };
		}
    }
}