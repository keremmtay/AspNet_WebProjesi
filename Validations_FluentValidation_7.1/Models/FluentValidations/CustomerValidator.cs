using FluentValidation;

namespace Validations_FluentValidation_7._1.Models.FluentValidations
{

    // İlgili validasyon işlemlerini yapabilmem için öncelikle FluentValidation içinde bulunan AbstractValidator<T> class'ını inherit etmem gerekiyor. T yerine de ben hangi modle/entity için validasyon yapacak isem o Class'ı yazmalıyım. Product yazarsam Product için doğrulama işlemleri yapacak. Customer yazarsam, Customer için doğrulama işlemlerini yapacak.
    // Daha sonra Veri doğrulama işlemini yapabilmek için bu sınıf için constructor oluşturuyorum. Ve aşağıdaki gibi validation işlemlerini yapıyorum.

    public class CustomerValidator : AbstractValidator<Customer>
    {


        public CustomerValidator() 
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name alanı boş geçilemez.");
            
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Name alanı en fazla 25 karakter olabilir.");
            
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name alanı en az 3 karakter olabilir.");


            RuleFor(x => x.KimlikNo).NotNull().WithMessage("KimikNo alanı zorunlu alandır.");

            RuleFor(x => x.KimlikNo).Length(11).WithMessage("KimlikNo alanı 11 karakter olmalıdır.");


            RuleFor(x => x.Email).NotNull().WithMessage("Email alanı zorunlu alandır.");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi girmediniz."); // veride @ olup olmadığını kontrol ediyor.
        }
    }
}
