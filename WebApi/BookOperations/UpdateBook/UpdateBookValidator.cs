using FluentValidation;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookValidator()
        {
            RuleFor(command => command.BookID).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}
