using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using System;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => DateTime.Now));
        }
    }
}