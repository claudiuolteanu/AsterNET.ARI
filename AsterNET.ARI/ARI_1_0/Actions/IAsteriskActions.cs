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
	
	public interface IAsteriskActions
	{
		/// <summary>
		/// Retrieve a dynamic configuration object.. 
		/// </summary>
		/// <param name="configClass">The configuration class containing dynamic configuration objects.</param>
		/// <param name="objectType">The type of configuration object to retrieve.</param>
		/// <param name="id">The unique identifier of the object to retrieve.</param>
		List<ConfigTuple> GetObject(string configClass, string objectType, string id);
		/// <summary>
		/// Create or update a dynamic configuration object.. 
		/// </summary>
		/// <param name="configClass">The configuration class containing dynamic configuration objects.</param>
		/// <param name="objectType">The type of configuration object to create or update.</param>
		/// <param name="id">The unique identifier of the object to create or update.</param>
		/// <param name="fields">The body object should have a value that is a list of ConfigTuples, which provide the fields to update. Ex. [ { "attribute": "directmedia", "value": "false" } ]</param>
		List<ConfigTuple> UpdateObject(string configClass, string objectType, string id, Dictionary<string, string> fields = null);
		/// <summary>
		/// Delete a dynamic configuration object.. 
		/// </summary>
		/// <param name="configClass">The configuration class containing dynamic configuration objects.</param>
		/// <param name="objectType">The type of configuration object to delete.</param>
		/// <param name="id">The unique identifier of the object to delete.</param>
		void DeleteObject(string configClass, string objectType, string id);
		/// <summary>
		/// Gets Asterisk system information.. 
		/// </summary>
		/// <param name="only">Filter information returned</param>
		AsteriskInfo GetInfo(string only = null);
		/// <summary>
		/// List Asterisk modules.. 
		/// </summary>
		List<Module> ListModules();
		/// <summary>
		/// Get Asterisk module information.. 
		/// </summary>
		/// <param name="moduleName">Module's name</param>
		Module GetModule(string moduleName);
		/// <summary>
		/// Load an Asterisk module.. 
		/// </summary>
		/// <param name="moduleName">Module's name</param>
		void LoadModule(string moduleName);
		/// <summary>
		/// Unload an Asterisk module.. 
		/// </summary>
		/// <param name="moduleName">Module's name</param>
		void UnloadModule(string moduleName);
		/// <summary>
		/// Reload an Asterisk module.. 
		/// </summary>
		/// <param name="moduleName">Module's name</param>
		void ReloadModule(string moduleName);
		/// <summary>
		/// Gets Asterisk log channel information.. 
		/// </summary>
		List<LogChannel> ListLogChannels();
		/// <summary>
		/// Adds a log channel.. 
		/// </summary>
		/// <param name="logChannelName">The log channel to add</param>
		/// <param name="configuration">levels of the log channel</param>
		void AddLog(string logChannelName, string configuration);
		/// <summary>
		/// Deletes a log channel.. 
		/// </summary>
		/// <param name="logChannelName">Log channels name</param>
		void DeleteLog(string logChannelName);
		/// <summary>
		/// Rotates a log channel.. 
		/// </summary>
		/// <param name="logChannelName">Log channel's name</param>
		void RotateLog(string logChannelName);
		/// <summary>
		/// Get the value of a global variable.. 
		/// </summary>
		/// <param name="variable">The variable to get</param>
		Variable GetGlobalVar(string variable);
		/// <summary>
		/// Set the value of a global variable.. 
		/// </summary>
		/// <param name="variable">The variable to set</param>
		/// <param name="value">The value to set the variable to</param>
		void SetGlobalVar(string variable, string value = null);
	}
}
