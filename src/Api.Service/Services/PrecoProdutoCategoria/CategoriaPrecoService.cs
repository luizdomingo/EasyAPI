using Api.Domain.Dtos.CategoriaPrecoDtos;
using Api.Domain.Entities.CategoriaPreco;
using Api.Domain.Interfaces.Services.CategoriaPreco;
using AutoMapper;
using Domain.Interfaces;
using Domain.Interfaces.Repository;

namespace Api.Service.Services.CategoriaPreco
{
    public class CategoriaPrecoService : ICategoriaPrecoService
    {
        private readonly IRepository<CategoriaPrecoEntity> _repository;
        private readonly IMapper _mapper;
        private readonly ICategoriaPrecoRepository _imprementacao;

        public CategoriaPrecoService(IRepository<CategoriaPrecoEntity> repository, IMapper mapper, ICategoriaPrecoRepository categoriaPrecoRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _imprementacao = categoriaPrecoRepository;
        }

        public async Task<IEnumerable<CategoriaPrecoDto>> GetAll()
        {
            try
            {
                IEnumerable<CategoriaPrecoEntity> entities = await _repository.SelectAsync();
                IEnumerable<CategoriaPrecoDto> dtos = _mapper.Map<IEnumerable<CategoriaPrecoDto>>(entities);
                return dtos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<CategoriaPrecoDto> Get(Guid id)
        {
            try
            {
                CategoriaPrecoEntity entity = await _repository.SelectAsync(id);
                CategoriaPrecoDto dto = _mapper.Map<CategoriaPrecoDto>(entity);
                return dto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<CategoriaPrecoDto> Create(CategoriaPrecoDtoCreate create)
        {
            try
            {
                CategoriaPrecoEntity entity = _mapper.Map<CategoriaPrecoEntity>(create);
                CategoriaPrecoEntity result = await _repository.InsertAsync(entity);
                CategoriaPrecoDto dto = _mapper.Map<CategoriaPrecoDto>(result);
                return dto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<CategoriaPrecoDto> Update(CategoriaPrecoDtoUpdate update)
        {
            try
            {
                CategoriaPrecoEntity entity = _mapper.Map<CategoriaPrecoEntity>(update);
                CategoriaPrecoEntity result = await _repository.UpdateAsync(entity);
                CategoriaPrecoEntity dto = _mapper.Map<CategoriaPrecoEntity>(result);


                return await Get(result.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<bool> Desabilitar(Guid id)
        {
            try
            {
                bool result = await _repository.DesabilitarHabilitar(id);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
