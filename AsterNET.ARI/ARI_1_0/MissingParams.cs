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
	/// Error event sent when required params are missing.
	/// </summary>
	public class MissingParams  : Message
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// A list of the missing parameters
		/// </summary>
		public List<string> Params { get; set; }

	}
}
