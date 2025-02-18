using Api.Domain.Dtos.CategoriaProdutoDtos;
using Api.Domain.Interfaces.Services.CategoriaProduto;
using Domain.Dtos;
using Domain.Dtos.CategoriaProdutoDtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ProdutosCategoriasController : ControllerBase
    {
        private readonly ICategoriaProdutoService _service;
        public ProdutosCategoriasController(ICategoriaProdutoService categoriaProdutoService)
        {
            _service = categoriaProdutoService;
        }

        [HttpGet("categorias")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> Get()
        {
            try
            {
                var result = await _service.Get();

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }
        [HttpGet("categorias/{id}/id")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> Get(Guid id)
        {
            try
            {
                var result = await _service.Get(id);

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }
        [HttpGet("categorias/{categoria}/categoria")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> Get(string categoria)
        {
            try
            {
                var result = await _service.Get(categoria);

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }

        [HttpPost("categorias/create")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> Create(CategoriaProdutoDtoCreate create)
        {
            try
            {
                var result = await _service.Create(create);

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }

        }
        [HttpPut("categorias/update")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> Update(CategoriaProdutoDtoUpdate categoriaProdutoDtoUpdate)
        {
            try
            {
                var result = await _service.Update(categoriaProdutoDtoUpdate);

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);

            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }
        [HttpPut("categorias/{id}/desabilitar")]
        public async Task<ActionResult<ResponseDto<List<CategoriaProdutoDto>>>> DesabilitarHabilitar(Guid id)
        {
            try
            {
                var result = await _service.DesabilitarHabilitar(id);

                if (!result.Status)
                    return BadRequest(result);

                return Ok(result);
            }
            catch (Exception ex)
            {
                ResponseDto<List<CategoriaProdutoDto>> response = new ResponseDto<List<CategoriaProdutoDto>>();
                response.Mensagem = $"Erro.Detalhes: {ex.Message}";
                response.Status = false;
                return BadRequest(response);
            }
        }

    }
}