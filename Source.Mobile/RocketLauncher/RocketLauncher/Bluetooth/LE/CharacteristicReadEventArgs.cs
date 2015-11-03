using System;

namespace RocketLauncher.Bluetooth.LE
{
	public class CharacteristicReadEventArgs : EventArgs
	{
		public ICharacteristic Characteristic { get; set; }

		public CharacteristicReadEventArgs ()
		{
		}
	}
}

