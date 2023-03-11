using AutoMapper;
using Kuari.Blog.Core.DTOs.Concrete;
using Kuari.Blog.Core.Entities.Concrete;

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

            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();

            CreateMap<ContactDto, Contact>().ReverseMap();
            CreateMap<ContactUpdateDto, Contact>().ReverseMap();

            CreateMap<AboutDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

        }
    }
}
