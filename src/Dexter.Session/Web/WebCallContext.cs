﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			WebCallContext.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2012/11/02
// Last edit:	2013/03/10
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dexter.Async.Web
{
	using System.Web;

	/// <summary>
	/// This class is the implementation of ICallContext
	/// </summary>
	public class WebCallContext : IWebCallContext
	{
		#region Public Indexers

		/// <summary>
		/// Gets the items.
		/// </summary>
		/// <value>The items.</value>
		public object this[string key]
		{
			get
			{
				return HttpContext.Current.Items[key];
			}

			set
			{
				HttpContext.Current.Items[key] = value;
			}
		}

		#endregion
	}
}