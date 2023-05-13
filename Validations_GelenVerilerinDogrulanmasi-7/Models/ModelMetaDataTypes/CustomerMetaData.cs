using System.ComponentModel.DataAnnotations;

namespace Validations_GelenVerilerinDogrulanmasi_7.Models.ModelMetaDataTypes
{
    public class CustomerMetaData
    {

        // Customer modelinin içindeki validation işlemi yapılacak property'leri buraya taşıyorum. 

        [Required(ErrorMessage = "Id alanı boş geçilemez.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name alanı boş geçilemez.")]
        [StringLength(25, ErrorMessage = "Name alanı en fazla 25 karakter olabilir."), MinLength(2, ErrorMessage = "Name alanı en az 2 karakter olmalı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "KimlikNo alanı boş geçilemez.")]
        [MaxLength(11, ErrorMessage = "Lütfen geçerli bir KimlikNo girin."), MinLength(11, ErrorMessage = "Lütfen geçerli bir KimlikNo girin.")]
        public string KimlikNo { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi girin. Örn: abc@xyz.com")]
        public string Email { get; set; }
    }
}
