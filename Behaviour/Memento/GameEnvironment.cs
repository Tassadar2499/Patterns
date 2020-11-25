using AutoMapper;
using System;

namespace Memento
{
	public class GameEnvironment
	{
		private static IMapper _mapper;

		public int MoneysCount { get; set; }
		public int CowsCount { get; set; }

		public GameEnvironment()
		{
			_mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<GameEnvironmentMemento, GameEnvironment>()));
		}

		public void BuyCow()
		{
			CowsCount++;
			MoneysCount--;
		}

		public void SellCow()
		{
			CowsCount--;
			MoneysCount++;
		}

		public void WriteToConsole()
			=> Console.WriteLine($"Коровы - {CowsCount}; Деньги - {MoneysCount}");

		public GameEnvironmentMemento SaveState()
			=> new GameEnvironmentMemento(CowsCount, MoneysCount);

		public void RestoreState(GameEnvironmentMemento memento)
			=> _ = _mapper.Map(memento, this);
	}
}