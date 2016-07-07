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
	/// Event showing the start of a media playback operation.
	/// </summary>
	public class PlaybackStartedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// Playback control object
		/// </summary>
		public Playback Playback { get; set; }

	}
}
