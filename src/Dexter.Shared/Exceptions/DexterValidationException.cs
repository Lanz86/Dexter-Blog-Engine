﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			DexterValidationException.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2013/05/09
// Last edit:	2013/05/09
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dexter.Shared.Exceptions
{
	public class DexterValidationException : DexterException
	{
		private readonly string propertyName;

		public DexterValidationException(string message, string propertyName)
			: base(message)
		{
			this.propertyName = propertyName;
		}

		public string PropertyName
		{
			get
			{
				return this.propertyName;
			}
		}
	}
}