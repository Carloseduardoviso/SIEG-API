using CrossCutting.IoC.Extensions;
using Historias.Produto.Criar;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [SwaggerResponse(200, "Produto criado com sucesso", typeof(int))]
        [SwaggerResponse(400, "Requisição Inválida")]
        [SwaggerResponse(422, type: typeof(ValidationProblemDetails))]
        public async Task<IActionResult> Criar([FromServices] CriarProduto criarProduto, [FromServices] CriarProdutoDto criarProdutoDto)
        {
            if (!ModelState.IsValid)
                return ValidationProblem(detail: "Falha nos dados inseridos para a criação do produto", title: "Falha na validação", statusCode: 422, modelStateDictionary: ModelState);

            var produtoId = await criarProduto.Executar(criarProdutoDto);

            if (criarProduto.Notifications.Any())
              return Problem(title: "Houve um problema ao criar o produto", statusCode: StatusCodes.Status400BadRequest, detail: $"{criarProduto.Notifications.Select(x => x.Message).ConcatenarStrings()}");

            return Ok(produtoId);
        }
    }
}
