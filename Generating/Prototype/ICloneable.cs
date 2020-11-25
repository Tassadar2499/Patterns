namespace Prototype
{
	public interface ICloneable
	{
		public ICloneable Clone();

		public ICloneable DeepCopy();
	}
}