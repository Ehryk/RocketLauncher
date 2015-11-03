using System;

namespace RocketLauncher.Bluetooth.LE
{
	public class DeviceDiscoveredEventArgs : EventArgs
	{
		public IDevice Device;

		public DeviceDiscoveredEventArgs() : base()
		{}
	}
}

