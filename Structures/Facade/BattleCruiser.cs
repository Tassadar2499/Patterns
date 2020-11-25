using Facade.Components;
using Facade.Components.Interfaces;

namespace Facade
{
	public class BattleCruiser : IShip
	{
		private readonly IGun _gun;
		private readonly IDrive _drive;
		private readonly IShield _shield;

		public BattleCruiser(IGun gun, IDrive drive, IShield shield)
		{
			_gun = gun;
			_drive = drive;
			_shield = shield;
		}

		public void PrepareToBattle()
		{
			_gun.WarmingUp();
			_shield.TurnShieldOn();
		}

		public void InitiateFighting()
		{
			_drive.Jump();
			_gun.Shoot();
		}

		public void Retreat()
		{
			_shield.TurnShieldOff();
			_drive.Jump();
		}
	}
}