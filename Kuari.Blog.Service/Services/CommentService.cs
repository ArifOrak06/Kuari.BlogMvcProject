using Kuari.Blog.Core.DTOs.Concrete.CommentDTOs;
using Kuari.Blog.Core.Entities.Concrete;
using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Core.Services;
using Kuari.Blog.Core.UnitOfWork;
using Kuari.Blog.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Service.Services
{
    public class CommentService : Service<Comment,CommentDto,CommentUpdateDto>, ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CommentService(ICommentRepository commentRepository, IUnitOfWork unitOfWork) : base(commentRepository,unitOfWork)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
