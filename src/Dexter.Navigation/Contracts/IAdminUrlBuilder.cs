﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			IAdminUrlBuilder.cs
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

namespace Dexter.Navigation.Contracts
{
	using Dexter.Navigation.Helpers;

	public enum FeedbackType
	{
		Positive, 

		Negative
	}

	public interface IAdminUrlBuilder
	{
		#region Public Properties

		IAdminCategoryUrlBuilder Category { get; }

		IAdminPageUrlBuilder Page { get; }

		IAdminPostUrlBuilder Post { get; }

		IAdminAccountUrlBuilder Account { get; }

		#endregion

		#region Public Methods and Operators

		SiteUrl EditConfiguration();

		SiteUrl EditSeoConfiguration();

		SiteUrl EditTrackingConfiguration();

		SiteUrl EditCommentsConfiguration();

		SiteUrl EditSmtpConfiguration();

		SiteUrl EditReadingConfiguration();

		SiteUrl FeedbackPage(FeedbackType feedback, string localizationKey, SiteUrl redirect);

		SiteUrl Home();

		SiteUrl Login();

		SiteUrl Logout();

		#endregion
	}
}