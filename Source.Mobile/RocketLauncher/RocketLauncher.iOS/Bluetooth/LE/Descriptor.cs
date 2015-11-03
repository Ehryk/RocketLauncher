﻿using System;
using RocketLauncher.Bluetooth.LE;

#if __UNIFIED__
using CoreBluetooth;
#else
using MonoTouch.CoreBluetooth;
#endif

namespace RocketLauncher.iOS.Bluetooth.LE
{
	public class Descriptor : IDescriptor
	{
		public /*CBDescriptor*/ object NativeDescriptor {
			get {
				return this._nativeDescriptor as object;
			}
		} protected CBDescriptor _nativeDescriptor; 

		public Guid ID {
			get {
				//return this._nativeDescriptor.UUID.ToString ();
				return Guid.ParseExact(this._nativeDescriptor.UUID.ToString (), "d");
			}
		}
		public string Name {
			get {
				if (this._name == null)
					this._name = KnownDescriptors.Lookup (this.ID).Name;
				return this._name;
			}
		} protected string _name = null;

		public Descriptor (CBDescriptor nativeDescriptor)
		{
			this._nativeDescriptor = nativeDescriptor;
		}
	}
}

