using FluentValidation;

namespace WebApi.BookOperations.GetById
{
    public class GetByIdValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdValidator()
        {
            RuleFor(command => command.BookID).GreaterThan(0);
        }
    }
}