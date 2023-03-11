using AutoMapper;
using Kuari.Blog.Core.DTOs.Concrete.ArticleDTOs;
using Kuari.Blog.Core.DTOs.Concrete.CategoryDTOs;
using Kuari.Blog.Core.DTOs.Concrete.CommentDTOs;
using Kuari.Blog.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Service.Mappings.AutoMapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();
            CreateMap<CommentUpdateDto, Comment>().ReverseMap();
        }
    }
}
