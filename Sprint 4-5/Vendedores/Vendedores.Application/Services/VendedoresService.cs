using AutoMapper;
using FluentResults;
using Newtonsoft.Json;
using Vendedores.Application.Dtos.Inputs;
using Vendedores.Application.Dtos.Outputs;
using Vendedores.Application.Services.Interfaces;
using Vendedores.Domain.Entidades;
using Vendedores.Domain.Repository;
using Vendedores.Domain.Services.Interfaces;

namespace Vendedores.Application.Services
{
    public sealed class VendedoresService : IVendedoresService
    {

        private readonly IVendedorDomainService _vendedorDomainService;
        private readonly IBaseRepository<Vendedor, VendedorAlteracao> _vendedoresRepository;
        private readonly IMapper _mapper;

        public VendedoresService(
            IVendedorDomainService vendedorDomainService, 
            IBaseRepository<Vendedor, VendedorAlteracao> vendedoresRepository, 
            IMapper mapper)
        {
            _vendedorDomainService = vendedorDomainService;
            _vendedoresRepository = vendedoresRepository;
            _mapper = mapper;
        }
        #region PERSISTÊNCIA
        public async Task<VendedorOutputDto?> AdicionaVendedorDb(CreateVendedorDto vendedorDto)
        {
            Vendedor vendedor = _mapper.Map<Vendedor>(vendedorDto);
            bool resp = await _vendedorDomainService.AdicionarVendedor(vendedor);

            if (!resp) return null;
            
            VendedorOutputDto output = _mapper.Map<VendedorOutputDto>(vendedor);
            return output;
        }
        
        public async Task<Result> EditVendedor(Guid id, EditVendedorDto vendedorDto)
        {
            Vendedor? vendedor = await _vendedoresRepository.GetById(id);
            if (vendedor == null) return Result.Fail("Vendedor não encontrado");

            VendedorAlteracao? vendedorAlteracao = SerializaAlteracao(vendedor);
            _mapper.Map(vendedorDto, vendedor);
            await _vendedorDomainService.AtualizarVendedor(vendedorAlteracao);

            return Result.Ok();
        }

        public async Task<Result> RemovePorId(Guid id)
        {

            bool resposta = await _vendedorDomainService.RemoverVendedor(id);
            if (!resposta) return Result.Fail("Vendedor não encontrado");

            return Result.Ok();

        }
        #endregion

        #region QUERY
        public async Task<VendedorByIdOutputDto> RecuperaVendedorId(GetVendedorDto dto)
        {

            Vendedor vendedor = await _vendedoresRepository.GetById(Guid.Parse(input: dto.Id));
           
            VendedorByIdOutputDto vendedorByIdOutputDTO = _mapper.Map<VendedorByIdOutputDto>(vendedor);
                
            return vendedorByIdOutputDTO;

        }
        
        public async Task<VendedorByQueryOutputDTO> RecuperaVendedorQuery(GetVendedorDto dto)
        {
            bool resp = DateTime.TryParse(dto.Query, out var date);
            if (resp)
            {
                var result = await _vendedoresRepository.Get(predicate: vendedor => vendedor.Nome == dto.Query
                || vendedor.DataNascimento == DateTime.Parse(dto.Query)
                || vendedor.DocIdentificacao == dto.Query
                || vendedor.DataCadastro == DateTime.Parse(dto.Query));

                List<VendedorOutputDto> vendedores = _mapper.Map<List<VendedorOutputDto>>(result);

                var output = new VendedorByQueryOutputDTO(vendedores);

                return output;
            }
            else
            {
                IEnumerable<Vendedor>? result = await _vendedoresRepository.Get(predicate: vendedor => vendedor.Nome == dto.Query ||
                vendedor.DocIdentificacao == dto.Query);

                List<VendedorOutputDto> vendedores = _mapper.Map<List<VendedorOutputDto>>(result);

                var output = new VendedorByQueryOutputDTO(vendedores);

                return output;
            }
        }

        public async Task<GetAllVendedoresOutputDto> RecuperaTodosVendedores()
        {
            List<Vendedor>? result = await _vendedoresRepository.GetAll();

            List<VendedorOutputDto> vendedores = _mapper.Map<List<VendedorOutputDto>>(result);

            var outputDTO = new GetAllVendedoresOutputDto(vendedores);

            return outputDTO;
        }
        #endregion

        public VendedorAlteracao SerializaAlteracao(Vendedor vendedor)
        {
            string? json = JsonConvert.SerializeObject(vendedor);

            var vendedorAlteracao = new VendedorAlteracao(vendedor.Id, json, DateTime.Now);

            return vendedorAlteracao;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}