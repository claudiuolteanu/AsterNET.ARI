/*
	AsterNET ARI Framework
	Automatically generated file @ 21.02.2017 16:42:34
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Base type for errors and events
	/// </summary>
	public class Message 
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// Indicates the type of this message.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The unique ID for the Asterisk instance that raised this event.
		/// </summary>
		public string Asterisk_id { get; set; }

	}
}
