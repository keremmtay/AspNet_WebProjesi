using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Validations_GelenVerilerinDogrulanmasi_7.Models.ModelMetaDataTypes;

namespace Validations_GelenVerilerinDogrulanmasi_7.Models
{

    [ModelMetadataType(typeof(CustomerMetaData))]
    public class Customer
    {

        // ModelMetaDataType ile validation işlemi yapmak istiyorum bu Class'ı aşağıdaki gibi sadece property'lerden oluşan bir yer haline getirmem gerekecek.


        public int Id { get; set; }
        public string Name { get; set; }
        public string KimlikNo { get; set; }
        public string Email { get; set; }





        // Annotations'lar ile Validation yapmamızı sağlayacak olan şartlarımızı yazıyor.

        //[Required(ErrorMessage ="Id alanı boş geçilemez.")]
        //public int Id { get; set; }
        //[Required(ErrorMessage = "Name alanı boş geçilemez.")]
        //[StringLength(25, ErrorMessage = "Name alanı en fazla 25 karakter olabilir."), MinLength(2, ErrorMessage = "Name alanı en az 2 karakter olmalı")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "KimlikNo alanı boş geçilemez.")]
        //[MaxLength(11, ErrorMessage = "Lütfen geçerli bir KimlikNo girin."), MinLength(11, ErrorMessage = "Lütfen geçerli bir KimlikNo girin.")]
        //public string KimlikNo { get; set; }
        //[Required(ErrorMessage = "Email alanı boş geçilemez.")]
        //[EmailAddress(ErrorMessage ="Lütfen geçerli bir email adresi girin. Örn: abc@xyz.com")]
        //public string Email { get; set; }
    }
}
