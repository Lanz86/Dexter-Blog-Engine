#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			PostCommentsCreationDateIndex.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/About.ashx
// Created:		2012/11/02
// Last edit:	2012/11/02
// License:		GNU Library General Public License (LGPL)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dexter.Data.Raven.Indexes.Reading
{
	using System;
	using System.Linq;

	using Dexter.Data.Raven.Domain;
	using Dexter.Entities;

	using global::Raven.Abstractions.Indexing;
	using global::Raven.Client.Indexes;

	public class PostCommentsCreationDateIndex : AbstractIndexCreationTask<ItemComments, PostCommentsCreationDateIndex.ReduceResult>
	{
		#region Constructors and Destructors

		public PostCommentsCreationDateIndex()
		{
			this.Map = postComments => postComments.SelectMany(comment => 
																	comment.Approved, (postComment, comment) 
																		=> new
																			{
																				comment.CreatedAt,
																				CommentId = comment.Id,
																				PostCommentsId = postComment.Id,
																				PostId = postComment.Item.Id,
																				Status = postComment.Item.Status,
																				postComment.Item.ItemPublishedAt
																			});

			this.Store(x => x.CreatedAt, FieldStorage.Yes);
			this.Store(x => x.CommentId, FieldStorage.Yes);
			this.Store(x => x.ItemId, FieldStorage.Yes);
			this.Store(x => x.PostCommentsId, FieldStorage.Yes);
			this.Store(x => x.Status, FieldStorage.Yes);
			this.Store(x => x.ItemPublishedAt, FieldStorage.Yes);
		}

		#endregion

		public class ReduceResult
		{
			#region Public Properties

			public int CommentId { get; set; }

			public DateTimeOffset CreatedAt { get; set; }

			public int PostCommentsId { get; set; }

			public int ItemId { get; set; }
			
			public ItemStatus Status { get; set; }

			public DateTimeOffset ItemPublishedAt { get; set; }

			#endregion
		}
	}
}