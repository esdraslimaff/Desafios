using FluentValidation;
using Oficina.WebAPI.DTOs;

namespace Oficina.WebAPI.Validator
{
    public class CriarOrcamentoValidator : AbstractValidator<CriarOrcamentoRequest>
    {
        public CriarOrcamentoValidator()
        {
            RuleFor(x => x.ClienteId)
                .GreaterThan(0).WithMessage("clienteId é obrigatório");

            RuleFor(x => x.VeiculoId)
                .GreaterThan(0).WithMessage("veiculoId é obrigatório");

            RuleFor(x => x.Itens)
                .NotEmpty().WithMessage("Deve existir pelo menos 1 item");

            RuleForEach(x => x.Itens).ChildRules(item =>
            {
                item.RuleFor(i => i.Descricao)
                    .NotEmpty().WithMessage("Descrição é obrigatória");

                item.RuleFor(i => i.Quantidade)
                    .GreaterThan(0).WithMessage("Quantidade deve ser maior que zero");

                item.RuleFor(i => i.ValorUnitario)
                    .GreaterThan(0).WithMessage("Valor unitário deve ser maior que zero");
            });
        }
    }
}
