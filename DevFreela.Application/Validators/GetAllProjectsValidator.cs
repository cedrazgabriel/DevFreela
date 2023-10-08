using FluentValidation;

namespace DevFreela.Application.Validators;

public class GetAllProjectsValidator : AbstractValidator<string>
{
    public GetAllProjectsValidator()
    {
        RuleFor(p => p)
            .NotEmpty()
            .NotNull()
            .WithMessage("O filtro é obrigatório");
    }
}