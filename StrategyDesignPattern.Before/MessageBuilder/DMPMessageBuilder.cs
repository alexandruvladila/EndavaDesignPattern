namespace StrategyDesignPattern.Before
{
    public class DMPMessageBuilder : IMessageBuilder
	{
        public Message Build(string data)
        {
			return new Message { Content = $"HL7 message for DMP built from '{data}'" };
		}
    }
}   