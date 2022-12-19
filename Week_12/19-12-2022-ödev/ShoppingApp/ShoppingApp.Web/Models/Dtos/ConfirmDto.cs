using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class ConfirmDto
    {
        [DisplayName("Email Adresi")]
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
