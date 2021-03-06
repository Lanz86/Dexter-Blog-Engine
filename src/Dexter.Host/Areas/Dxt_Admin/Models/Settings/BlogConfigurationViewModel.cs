﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			BlogConfigurationViewModel.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2013/04/01
// Last edit:	2013/04/01
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dexter.Host.Areas.Dxt_Admin.Models.Settings
{
	using System;
	using System.Collections.ObjectModel;

	using Dexter.Host.Areas.Dxt_Admin.Binders;
	using Dexter.Web.Core.Models;

	public class BlogConfigurationViewModel : DexterBackofficeModelBase
	{
		#region Public Properties

		public BlogConfigurationBinder BlogConfiguration { get; set; }

		public ReadOnlyCollection<TimeZoneInfo> TimesZones { get; set; }

		#endregion
	}
}