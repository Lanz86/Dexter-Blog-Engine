﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			AdminUrlBuilder.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2012/10/28
// Last edit:	2013/01/20
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////
#endregion

namespace Dexter.Navigation.Concretes
{
	using System.Collections.Generic;

	using Dexter.Navigation.Contracts;
	using Dexter.Navigation.Helpers;
	using Dexter.Services;

	public class AdminUrlBuilder : UrlBuilderBase, IAdminUrlBuilder
	{
		#region Constructors and Destructors

		public AdminUrlBuilder(IConfigurationService configurationService, IAdminPostUrlBuilder post, IAdminPageUrlBuilder page, IAdminCategoryUrlBuilder category, IAdminAccountUrlBuilder account)
			: base(configurationService)
		{
			this.Post = post;
			this.Page = page;
			this.Category = category;
			this.Account = account;
		}

		#endregion

		#region Public Properties

		public IAdminCategoryUrlBuilder Category { get; private set; }

		public IAdminPageUrlBuilder Page { get; private set; }

		public IAdminPostUrlBuilder Post { get; private set; }

		public IAdminAccountUrlBuilder Account { get; private set; }

		#endregion

		#region Public Methods and Operators

		public SiteUrl EditConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Configuration", null, null);
		}

		public SiteUrl EditSeoConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Seo", null, null);
		}

		public SiteUrl EditTrackingConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Tracking", null, null);
		}

		public SiteUrl EditCommentsConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Comments", null, null);
		}

		public SiteUrl EditSmtpConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Smtp", null, null);
		}

		public SiteUrl EditReadingConfiguration()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Settings", "Reading", null, null);
		}

		public SiteUrl FeedbackPage(FeedbackType feedback, string localizationKey, SiteUrl redirect)
		{
			var parameters = new Dictionary<string, string>
				                 {
					                 { "key", localizationKey },
					                 { "url", redirect }
				                 };

			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Feedback", feedback.ToString(), null, parameters);
		}

		public SiteUrl Home()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Home", "Index", null, null);
		}

		public SiteUrl Login()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Login", "Index", null, null);
		}

		public SiteUrl Logout()
		{
			return new SiteUrl(this.Domain, this.HttpPort, false, "Dxt-Admin", "Login", "Logout", null, null);
		}

		#endregion
	}
}