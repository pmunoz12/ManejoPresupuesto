using slnManejoPresupuesto.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace slnManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo es {0} y debe estar entre {1} y {2}")]
        [Display(Name = "Nombre del tipo de cuenta")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        //Pruebas de otras validacione spor defecto
        //[Required(ErrorMessage = "El {0} es requerido")]
        //[EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        //public string Email { get; set; }

        //[Range(minimum:18, maximum:130, ErrorMessage = "La edad debe estar entre {1} y {2}")]
        //public string Edad { get; set; }

        //[Url(ErrorMessage = "Debe ser una URL Valida")]
        //public string Url { get; set; }
        //[CreditCard(ErrorMessage = "La tarjeta no es valida")]
        //public string TarjetadeCredito { get; set; }
    }
}
