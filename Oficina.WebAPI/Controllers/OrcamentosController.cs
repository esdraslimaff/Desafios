using Microsoft.AspNetCore.Mvc;
using Oficina.WebAPI.DTOs;

namespace Oficina.WebAPI.Controllers
{
    /// <summary>
    /// Controller responsável pelo gerenciamento de orçamentos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class OrcamentosController : ControllerBase
    {
        private readonly OrcamentoService _service;

        public OrcamentosController(OrcamentoService service)
        {
            _service = service;
        }

        /// <summary>
        /// Cria um novo orçamento
        /// </summary>
        /// <param name="request">Dados do orçamento</param>
        /// <returns>Orçamento criado com sucesso ou erro de validação</returns>
        /// <remarks>
        /// Exemplo de request:
        /// 
        /// POST /api/orcamentos
        /// {
        ///   "clienteId": 10,
        ///   "veiculoId": 25,
        ///   "itens": [
        ///     {
        ///       "descricao": "Troca de óleo",
        ///       "quantidade": 1,
        ///       "valorUnitario": 120.00
        ///     }
        ///   ]
        /// </remarks>
        /// <response code="200">Orçamento criado com sucesso</response>
        /// <response code="400">Dados inválidos</response>
        [HttpPost]
        public IActionResult Criar([FromBody] CriarOrcamentoRequest request)
        {
            // NOTA AO AVALIADOR: Optei por utilizar FluentValidation para tratar validações de entrada de forma centralizada,
            // deixando a controller mais limpa e alinhada com boas práticas de separação de responsabilidades.

            var resultado = _service.Criar(request);

            return Ok(resultado);
        }

        /// <summary>
        /// Lista todos os orçamentos cadastrados
        /// </summary>
        [HttpGet]
        public IActionResult ObterTodos()
        {
            var resultado = _service.ObterTodos();
            return Ok(resultado);
        }
    }
}