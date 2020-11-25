using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public interface IHandler
	{
		public Task ExecuteAsync(Request request);
	}
}