﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			ICommentDataService.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2012/10/27
// Last edit:	2013/01/20
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////
#endregion

namespace Dexter.Data
{
	using System.Collections.Generic;

	using Dexter.Entities;
	using Dexter.Entities.Filters;

	public interface ICommentDataService
	{
		#region Public Methods and Operators

		void AddComment(CommentDto comment, int itemId, CommentStatus status);

		IList<CommentDto> GetCommentForSpecificItem(int itemId, CommentQueryFilter filters);

		IList<CommentDto> GetRecentApprovedComments(int maxNumberOfComments, ItemQueryFilter filters);

		#endregion
	}
}