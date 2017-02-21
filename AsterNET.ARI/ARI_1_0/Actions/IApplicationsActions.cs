﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 21.02.2017 16:42:34
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Models;
using AsterNET.ARI;

namespace AsterNET.ARI.Actions
{
	
	public interface IApplicationsActions
	{
		/// <summary>
		/// List all applications.. 
		/// </summary>
		List<Application> List();
		/// <summary>
		/// Get details of an application.. 
		/// </summary>
		/// <param name="applicationName">Application's name</param>
		Application Get(string applicationName);
		/// <summary>
		/// Subscribe an application to a event source.. Returns the state of the application after the subscriptions have changed
		/// </summary>
		/// <param name="applicationName">Application's name</param>
		/// <param name="eventSource">URI for event source (channel:{channelId}, bridge:{bridgeId}, endpoint:{tech}[/{resource}], deviceState:{deviceName}</param>
		Application Subscribe(string applicationName, string eventSource);
		/// <summary>
		/// Unsubscribe an application from an event source.. Returns the state of the application after the subscriptions have changed
		/// </summary>
		/// <param name="applicationName">Application's name</param>
		/// <param name="eventSource">URI for event source (channel:{channelId}, bridge:{bridgeId}, endpoint:{tech}[/{resource}], deviceState:{deviceName}</param>
		Application Unsubscribe(string applicationName, string eventSource);
	}
}
