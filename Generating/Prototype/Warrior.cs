using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
	[Serializable]
	public abstract class Warrior : ICloneable
	{
		public string Name { get; set; }

		public virtual void ShowInfo()
			=> Console.WriteLine(GetType().Name);

		protected Warrior(string name)
		{
			Name = name;
		}

		public ICloneable Clone()
			=> MemberwiseClone() as ICloneable;

		public ICloneable DeepCopy()
		{
			object obj = null;
			using (MemoryStream tempStream = new MemoryStream())
			{
				BinaryFormatter binFormatter = new BinaryFormatter(null,
					new StreamingContext(StreamingContextStates.Clone));

				binFormatter.Serialize(tempStream, this);
				tempStream.Seek(0, SeekOrigin.Begin);

				obj = binFormatter.Deserialize(tempStream);
			}

			return obj as ICloneable;
		}
	}
}