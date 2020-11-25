using System;
using System.Linq;
using System.Reflection;

namespace Decorator.DecoratorClasses
{
	public class AbstractDecorator<T>
	{
		protected readonly T _mainObject;

		protected AbstractDecorator(T mainObject)
		{
			if (mainObject == null)
				throw new ArgumentNullException($"{nameof(mainObject)} is null");

			_mainObject = mainObject;
		}

		internal V GetValue<V>(string name)
			=> (V)GetPropertyByName(name).GetValue(_mainObject);

		internal void SetValue(string name, object value)
			=> GetPropertyByName(name).SetValue(_mainObject, value);

		internal void InvokeVoidMethod(string name)
			=> _mainObject.GetType().GetRuntimeMethod(name, new Type[] { }).Invoke(_mainObject, null);

		private PropertyInfo GetPropertyByName(string propertyName)
			=> _mainObject.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == propertyName)
				?? throw new Exception($"Cannot find property by {propertyName}");
	}
}