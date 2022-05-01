using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    
        public class WriterValidator : AbstractValidator<Writer>
        {
            public WriterValidator()
            {
                RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş bırakılamaz");
                RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadı boş bırakılamaz");
                RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında boş bırakılamaz");
                RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Kategori adı en az üç karakter olmalıdır");
                RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Kategori adı en az üç karakter olmalıdır");
                RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karakter olmalıdır");
                RuleFor(x => x.WriterTitle).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karakter olmalıdır");
                RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Kategori adı en fazla 20 karakter olmalıdır");
                
            }

        }

    }

