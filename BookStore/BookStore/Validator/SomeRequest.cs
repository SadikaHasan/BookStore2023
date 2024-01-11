using BookStore.BookStore.Models.request;
using FluentValidation;

namespace BookStore.BookStore.Validator
{
    public class SomeRequest :
        AbstractValidator<SellAllBooksByAuthotRequest>
    {

        public SomeRequest()
            {
            RuleFor(x => x.authorId)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10)
                .WithMessage("Some error");

            RuleFor(x => x.ReleaseDate)
                .NotNull()
                .NotEmpty();
            }
    }
}
