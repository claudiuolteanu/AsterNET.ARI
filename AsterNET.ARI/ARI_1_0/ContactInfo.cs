﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 21.02.2017 16:42:34
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Detailed information about a contact on an endpoint.
	/// </summary>
	public class ContactInfo 
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// The location of the contact.
		/// </summary>
		public string Uri { get; set; }

		/// <summary>
		/// The current status of the contact.
		/// </summary>
		public string Contact_status { get; set; }

		/// <summary>
		/// The Address of Record this contact belongs to.
		/// </summary>
		public string Aor { get; set; }

		/// <summary>
		/// Current round trip time, in microseconds, for the contact.
		/// </summary>
		public string Roundtrip_usec { get; set; }

	}
}
