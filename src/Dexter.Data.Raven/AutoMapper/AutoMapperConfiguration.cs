﻿#region Disclaimer/Info

// ////////////////////////////////////////////////////////////////////////////////////////////////
// File:			AutoMapperConfiguration.cs
// Website:		http://dexterblogengine.com/
// Authors:		http://dexterblogengine.com/aboutus
// Created:		2012/10/27
// Last edit:	2013/03/18
// License:		New BSD License (BSD)
// For updated news and information please visit http://dexterblogengine.com/
// Dexter is hosted to Github at https://github.com/imperugo/Dexter-Blog-Engine
// For any question contact info@dexterblogengine.com
// ////////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dexter.Data.Raven.AutoMapper
{
	using System;

	using global::AutoMapper;

	using Dexter.Data.Raven.Domain;
	using Dexter.Data.Raven.Helpers;
	using Dexter.Entities;

	public class AutoMapperConfiguration
	{
		#region Public Methods and Operators

		public static void Configure()
		{
			Mapper.CreateMap<ItemDto, Item>()
			      .ForMember(dest => dest.Id, opt => opt.MapFrom(x => RavenIdHelper.Resolve<Post>(x.Id)))
			      .ForMember(dest => dest.SearchContent, opt => opt.MapFrom(x => x.Content.CleanHtmlText()))
			      .Include<PostDto, Post>()
			      .Include<PageDto, Page>();

			Mapper.CreateMap<Item, ItemDto>()
			      .ForMember(dest => dest.Id, opt => opt.MapFrom(x => RavenIdHelper.Resolve(x.Id)))
			      .Include<Post, PostDto>()
			      .Include<Page, PageDto>();

			Mapper.CreateMap<PostDto, Post>().ReverseMap();

			Mapper.CreateMap<PageDto, Page>()
			      .ForMember(dest => dest.ParentId, opt => opt.MapFrom(x => RavenIdHelper.Resolve<Page>(x.ParentId)))
			      .ForMember(dest => dest.PagesId, opt => opt.MapFrom(x => RavenIdHelper.Resolve<Page>(x.PagesId)));

			Mapper.CreateMap<Comment, CommentDto>().ReverseMap();
			Mapper.CreateMap<Category, CategoryDto>().ReverseMap();
			Mapper.CreateMap<EmailMessage, EmailMessageDto>().ReverseMap();
		}

		#endregion
	}
}