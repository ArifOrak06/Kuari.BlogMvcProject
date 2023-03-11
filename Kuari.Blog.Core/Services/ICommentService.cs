using Kuari.Blog.Core.DTOs.Concrete;
using Kuari.Blog.Core.Entities.Concrete;

namespace Kuari.Blog.Core.Services
{
    public interface ICommentService : IService<Comment,CommentDto,CommentUpdateDto>
    {
    }
}
