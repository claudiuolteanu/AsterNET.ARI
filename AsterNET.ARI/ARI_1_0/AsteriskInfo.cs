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
	/// Asterisk system information
	/// </summary>
	public class AsteriskInfo 
	{

		/// <summary>
		///
		/// </summary>
		// public AsteriskActions Asteris { get; set; }


		/// <summary>
		/// Info about how Asterisk was built
		/// </summary>
		public BuildInfo Build { get; set; }

		/// <summary>
		/// Info about the system running Asterisk
		/// </summary>
		public SystemInfo System { get; set; }

		/// <summary>
		/// Info about Asterisk configuration
		/// </summary>
		public ConfigInfo Config { get; set; }

		/// <summary>
		/// Info about Asterisk status
		/// </summary>
		public StatusInfo Status { get; set; }

	}
}
