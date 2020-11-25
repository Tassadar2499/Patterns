namespace Adapter
{
	public class Overmind
	{
		public void SendOrder(IZerg zerg)
			=> zerg.ExecuteOrder();
	}
}