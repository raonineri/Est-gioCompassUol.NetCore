using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Vendedores.Application.Dtos.Inputs;
using Vendedores.Application.Dtos.Outputs;
using Vendedores.Application.Services.Interfaces;

namespace Vendedores.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedorController : Controller
    {

        private IVendedoresService _vendedorService;


        public VendedorController(IVendedoresService vendedoresService)
        {
            _vendedorService = vendedoresService;
        }

        /// <summary>
        ///  Cria um Vendedor.
        /// </summary>
        /// <param name="vendedorDto"></param>
        /// <returns>O vendedor recem criado</returns>
        /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     POST api/Vendedor
        ///     {
        ///         "nome": "Sicrano",
        ///         "dataDeNascimento": "2024-01-16T00:00:00"
        ///         "docIdentificacao": "000.000.000-00"
        ///     }
        ///     
        /// </remarks>
        /// <response code="200">Retorna o vendedor recém criado</response>
        /// <response code="400">Erro na requisição</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> AdicionaVendedorAsync([FromBody] CreateVendedorDto vendedorDto)
        {

            try
            {
                VendedorOutputDto? vendedor = await _vendedorService.AdicionaVendedorDb(vendedorDto);
                if (vendedor == null) return BadRequest();

                return Ok(vendedor);

            }
            catch (Exception)
            {
                return BadRequest("Erro na requisição");
            }
        }


        /// <summary>
        /// Recupera um ou vários Vendedores a partir dos parametros: string? id e string? query.
        /// 
        /// Ambos poderão ser nulos, neste caso todos os registros serão buscados.
        /// 
        /// Em caso de apenas o id ser passado, será buscado somente pelo Id.
        /// Em caso de apenas a query ser preenchido, será buscado um ou 
        /// mais registros que atendam aquela requisição.
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>Um JSON contendo a lista de Vendedores</returns>
        /// <remarks>
        /// Exemplos de requisição:
        /// 
        ///     GET api/Vendedor/
        ///     GET api/Vendedor/?id=00000000-0000-0000-0000-000000000000
        ///     GET api/Vendedor/?query=Raoni
        /// 
        /// </remarks>
        /// <response code="200">JSON retornado com sucesso.</response>
        /// <response code="404">Nenhum registro foi encontrado.</response>
        /// <response code="400">Erro na requisição.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RecuperaMultiplosParametrosAsync([FromQuery] GetVendedorDto dto)
        {
            if (dto.Id != null)
            {
                try
                {
                    VendedorByIdOutputDto? vendedor = await _vendedorService.RecuperaVendedorId(dto);
                    if (vendedor != null)
                    {

                        return Ok(vendedor);
                    }
                    else
                    {
                        return NotFound();
                    }

                }
                catch (Exception e)
                {
                    return BadRequest($"Erro na requisição... {e.Message}");
                }
            }
            else if (dto.Query != null)
            {

                try
                {
                    VendedorByQueryOutputDTO? vendedor = await _vendedorService.RecuperaVendedorQuery(dto);
                    if (vendedor != null) return Ok(vendedor);

                    return NotFound();

                }
                catch (Exception e)
                {
                    return BadRequest($"Erro na requisição...{e.Message}");
                }
            }
            try
            {
                return base.Ok(await _vendedorService.RecuperaTodosVendedores());

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na requisição...{e.Message}");
            }
        }

        /// <summary>
        /// Altera o registro de um vendedor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vendedorDto"></param>
        /// <returns>Retorna o status da requisição</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///     
        ///     PUT api/Vendedor/00000000-0000-0000-0000-000000000000
        ///     {
        ///         "Nome": "Raoni Neri",
        ///         "DataNascimento": 17/05/1999",
        ///         "DocIdentificacao": "000.000.000-90"
        ///     }
        /// 
        /// </remarks>
        /// <response code="404">NotFound Caso o ID informado não corresponda a nenhum registro</response>
        /// <response code="204">NoContent Caso a alteração no registro tenha acontecido com sucesso</response>
        /// <response code="400">BadRequest Caso haja algum erro na requisição</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AtualizaVendedor(Guid id, [FromBody] EditVendedorDto vendedorDto)
        {
            try
            {
                Result resposta = await _vendedorService.EditVendedor(id, vendedorDto);

                if (resposta.IsFailed) return NotFound();

                return NoContent();

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na requisição... {e.Message}");
            }
        }

        /// <summary>
        /// Deleta o registro de um Vendedor especifico 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o status da requisição</returns>
        /// <remarks>
        /// Exemplo de requisição:
        /// 
        ///     DELETE /api/Vendedor/00000000-0000-0000-0000-000000000000
        ///     
        /// </remarks>
        /// <response code="404">NotFound Caso o ID informado não corresponda a nenhum registro.</response>
        /// <response code="204">NoContent Caso a remoção do registro tenha acontecido com sucesso.</response>
        /// <response code="400">BadRequest Caso haja algum erro na requisição.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeletaVendedorAsync(Guid id)
        {
            try
            {
                Result resposta = await _vendedorService.RemovePorId(id);

                if (resposta.IsFailed) return NotFound();

                return NoContent();

            }
            catch (Exception e)
            {
                return BadRequest($"Erro na requisição...{e.Message}");
            }
        }
    }
}
