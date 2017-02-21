﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 21.02.2017 16:42:34
*/
using System.Collections.Generic;
using System.Linq;
using AsterNET.ARI.Middleware;
using AsterNET.ARI.Models;
using Newtonsoft.Json;

namespace AsterNET.ARI.Actions
{
	
	public class DeviceStatesActions : ARIBaseAction, IDeviceStatesActions
	{

		public DeviceStatesActions(IActionConsumer consumer)
			: base(consumer)
		{}

		/// <summary>
		/// List all ARI controlled device states.. 
		/// </summary>
		public List<DeviceState> List()
		{
			string path = "/deviceStates";
			var request = GetNewRequest(path, HttpMethod.GET);

			var response = Execute<List<DeviceState>>(request);

			if((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
				return response.Data;
			switch((int)response.StatusCode)
            {
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code from ARI. Error message {0}. Exception {1}", response.ErrorMessage, response.ErrorException.ToString()), (int)response.StatusCode);
            }
		}
		/// <summary>
		/// Retrieve the current state of a device.. 
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		public DeviceState Get(string deviceName)
		{
			string path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.GET);
			if(deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);

			var response = Execute<DeviceState>(request);

			if((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
				return response.Data;
			switch((int)response.StatusCode)
            {
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code from ARI. Error message {0}. Exception {1}", response.ErrorMessage, response.ErrorException.ToString()), (int)response.StatusCode);
            }
		}
		/// <summary>
		/// Change the state of a device controlled by ARI. (Note - implicitly creates the device state).. 
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		/// <param name="deviceState">Device state value</param>
		public void Update(string deviceName, string deviceState)
		{
			string path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.PUT);
			if(deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);
			if(deviceState != null)
				request.AddParameter("deviceState", deviceState, ParameterType.QueryString);
			var response = Execute(request);
			if((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
				return;
			switch((int)response.StatusCode)
            {
				case 404:
					throw new AriException("Device name is missing", (int)response.StatusCode);
				case 409:
					throw new AriException("Uncontrolled device specified", (int)response.StatusCode);
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code from ARI. Error message {0}. Exception {1}", response.ErrorMessage, response.ErrorException.ToString()), (int)response.StatusCode);
            }
		}
		/// <summary>
		/// Destroy a device-state controlled by ARI.. 
		/// </summary>
		/// <param name="deviceName">Name of the device</param>
		public void Delete(string deviceName)
		{
			string path = "/deviceStates/{deviceName}";
			var request = GetNewRequest(path, HttpMethod.DELETE);
			if(deviceName != null)
				request.AddUrlSegment("deviceName", deviceName);
			var response = Execute(request);
			if((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
				return;
			switch((int)response.StatusCode)
            {
				case 404:
					throw new AriException("Device name is missing", (int)response.StatusCode);
				case 409:
					throw new AriException("Uncontrolled device specified", (int)response.StatusCode);
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code from ARI. Error message {0}. Exception {1}", response.ErrorMessage, response.ErrorException.ToString()), (int)response.StatusCode);
            }
		}
	}
}

