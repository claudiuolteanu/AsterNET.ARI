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
	/// The merging of media from one or more channels.  Everyone on the bridge receives the same audio.
	/// </summary>
	public class Bridge 
	{

		/// <summary>
		///
		/// </summary>
		// public BridgesActions Bridge { get; set; }


		/// <summary>
		/// Unique identifier for this bridge
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Name of the current bridging technology
		/// </summary>
		public string Technology { get; set; }

		/// <summary>
		/// Type of bridge technology
		/// </summary>
		public string Bridge_type { get; set; }

		/// <summary>
		/// Bridging class
		/// </summary>
		public string Bridge_class { get; set; }

		/// <summary>
		/// Entity that created the bridge
		/// </summary>
		public string Creator { get; set; }

		/// <summary>
		/// Name the creator gave the bridge
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Ids of channels participating in this bridge
		/// </summary>
		public List<string> Channels { get; set; }

		/// <summary>
		/// The video mode the bridge is using. One of 'none', 'talker', or 'single'.
		/// </summary>
		public string Video_mode { get; set; }

		/// <summary>
		/// The ID of the channel that is the source of video in this bridge, if one exists.
		/// </summary>
		public string Video_source_id { get; set; }

	}
}
