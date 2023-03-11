using Kuari.Blog.Core.DTOs.Abstract;
using Kuari.Blog.SharedLibrary.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.Services
{
    public interface IService<TEntity,TDto,TUpdateDto>
        where TEntity : class
        where TUpdateDto : IUpdateDto
        where TDto : class
    {
        Task<CustomResponseDto<TDto>> AddAsync(TDto dto);
        Task<CustomResponseDto<NoContentDto>> DeleteAsync(TDto dto);
        Task<CustomResponseDto<TUpdateDto>> UpdateAsync(TUpdateDto updateDto);
        Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync();
        Task<CustomResponseDto<IEnumerable<TDto>>> GetAllByFilterAsync(Expression<Func<TEntity, bool>> filter);
        Task<CustomResponseDto<TDto>> GetByIdAsync(int id);

    }
}
