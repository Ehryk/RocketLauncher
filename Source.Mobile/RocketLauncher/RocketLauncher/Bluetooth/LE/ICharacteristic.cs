using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RocketLauncher.Bluetooth.LE
{
	public interface ICharacteristic
	{
		// events
		event EventHandler<CharacteristicReadEventArgs> ValueUpdated;

		// properties
		Guid ID { get; }
		string Uuid { get; }
		byte[] Value { get; }
		string StringValue { get; }
		IList<IDescriptor> Descriptors { get; }
		object NativeCharacteristic { get; }
		string Name { get; }
		CharacteristicPropertyType Properties { get; }

		bool CanRead { get; }
		bool CanUpdate { get; }
		bool CanWrite { get; }

		// methods
//		void EnumerateDescriptors ();

		void StartUpdates();
		void StopUpdates();

		Task<ICharacteristic> ReadAsync ();

		void Write (byte[] data);

	}
}

