namespace StrategyDesignPattern.After
{
	public interface IMessageBuilder
	{
		Message Build(string message);
	}
}