using Kuari.Blog.Core.DTOs.Abstract;
using Kuari.Blog.Core.Repositories;
using Kuari.Blog.Core.Services;
using Kuari.Blog.Core.UnitOfWork;
using Kuari.Blog.Service.Mappings.AutoMapper;
using Kuari.Blog.SharedLibrary.ResponseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Service.Services
{
    public class Service<TEntity, TDto, TUpdateDto> : IService<TEntity, TDto, TUpdateDto>
        where TEntity : class
        where TUpdateDto : IUpdateDto
        where TDto : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponseDto<TDto>> AddAsync(TDto dto)
        {
            if (dto == null)
            {
                return CustomResponseDto<TDto>.Fail(404, "Geçerli nesne gönderilmemesi nedeniyle ekleme işlemi başarısız");

            }
            var entity = ObjectMapper.Mapper.Map<TEntity>(dto);
            await _repository.AddASync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = ObjectMapper.Mapper.Map<TDto>(entity);
            return CustomResponseDto<TDto>.Success(200,newDto);
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteAsync(TDto dto)
        {
            if(dto == null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, "Sistemdeki herhangi bir ürünle eşleştirilemedi, bu nedenle silme başarısız.");
            }
            var entity = ObjectMapper.Mapper.Map<TEntity>(dto);
            _repository.Delete(entity);
            await _unitOfWork.CommitAsync();
          
            return CustomResponseDto<NoContentDto>.Success(200);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            if (entities == null)
            {
                return CustomResponseDto<IEnumerable<TDto>>.Fail(404,"Listeleme işlemi başarısız");
            }
            var dtos = ObjectMapper.Mapper.Map<IEnumerable<TDto>>(entities);
            return CustomResponseDto<IEnumerable<TDto>>.Success(200, dtos);
        }

        public async Task<CustomResponseDto<IEnumerable<TDto>>> GetAllByFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            if (filter == null)
            {
                return CustomResponseDto<IEnumerable<TDto>>.Fail(404, "Filtreleme başarısız");
            }
            var data = await _repository.GetByFilterAsync(filter);

            var dataDto = ObjectMapper.Mapper.Map<IEnumerable<TDto>>(data);

            return CustomResponseDto<IEnumerable<TDto>>.Success(200,dataDto);
            
        }

        public async Task<CustomResponseDto<TDto>> GetByIdAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null)
            {
                return CustomResponseDto<TDto>.Fail(404, "belirtilen id'ye sahip data bulunamamıştır.");
            }
            var dataDto = ObjectMapper.Mapper.Map<TDto>(data);
            return CustomResponseDto<TDto>.Success(200, dataDto);
        }

        public async Task<CustomResponseDto<TUpdateDto>> UpdateAsync(TUpdateDto updateDto)
        {
            var unChangedEntity = await _repository.GetByIdAsync(updateDto.Id);
            if (unChangedEntity == null)
            {
                return CustomResponseDto<TUpdateDto>.Fail(404, "Girilen ID ile eşleşen bir veri bulunmaması nedeniyle güncelleme işlemi yapılamamıştır.");
            }
            var updatedEntity = ObjectMapper.Mapper.Map<TEntity>(updateDto);
            _repository.Update(updatedEntity);
            await _unitOfWork.CommitAsync();

            var newUpdatedDto = ObjectMapper.Mapper.Map<TUpdateDto>(updatedEntity);

            return CustomResponseDto<TUpdateDto>.Success(200, newUpdatedDto);
     
        }
    }
}
