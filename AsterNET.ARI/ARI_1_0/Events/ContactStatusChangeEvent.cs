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
	/// The state of a contact on an endpoint has changed.
	/// </summary>
	public class ContactStatusChangeEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// no description provided
		/// </summary>
		public Endpoint Endpoint { get; set; }

		/// <summary>
		/// no description provided
		/// </summary>
		public ContactInfo Contact_info { get; set; }

	}
}
