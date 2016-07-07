/*
	AsterNET ARI Framework
	Automatically generated file @ 06.07.2016 13:07:09
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Notification that a device state has changed.
	/// </summary>
	public class DeviceStateChangedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// Device state object
		/// </summary>
		public DeviceState Device_state { get; set; }

	}
}
