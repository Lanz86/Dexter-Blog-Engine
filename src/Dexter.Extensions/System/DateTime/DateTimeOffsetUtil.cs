﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			DateTimeOffsetUtil.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2012/11/02
// Last edit:	2013/01/20
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////
#endregion

namespace System
{
	public static class DateTimeOffsetUtil
	{
		#region Public Methods and Operators

		public static DateTimeOffset AsMinutes(this DateTimeOffset self)
		{
			return new DateTimeOffset(self.Year, self.Month, self.Day, self.Hour, self.Minute, 0, 0, self.Offset);
		}

		public static DateTimeOffset ConvertFromJsTimestamp(long timestamp)
		{
			DateTimeOffset origin = new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, DateTimeOffset.Now.Offset);
			return origin.AddMilliseconds(timestamp);
		}

		public static DateTimeOffset ConvertFromUnixTimestamp(long timestamp)
		{
			DateTimeOffset origin = new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, DateTimeOffset.Now.Offset);
			return origin.AddSeconds(timestamp);
		}

		#endregion
	}
}