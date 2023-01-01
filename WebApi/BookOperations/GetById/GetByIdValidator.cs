using FluentValidation;

namespace WebApi.BookOperations.GetById
{
    public class GetByIdValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdValidator()
        {
            RuleFor(query => query.BookID).GreaterThan(0);
        }
    }
}
