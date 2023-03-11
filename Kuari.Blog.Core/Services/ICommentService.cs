using Kuari.Blog.Core.DTOs.Concrete.CommentDTOs;
using Kuari.Blog.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Services
{
    public interface ICommentService : IService<Comment,CommentDto,CommentUpdateDto>
    {
    }
}
