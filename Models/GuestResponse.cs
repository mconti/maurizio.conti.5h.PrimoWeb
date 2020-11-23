using System.ComponentModel.DataAnnotations;

namespace maurizio.conti._5h.PrimoWeb.Models
{
    public class GuestResponse {
        [Required(ErrorMessage = "Inserisci il tuo nome...")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Inserisci una EMail valida")] 
        [EmailAddress]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Inserisci il tuo numero di telefono")]
        public string Telefono { get; set; }
        
        [Required(ErrorMessage = "Parteciperai al party?")]
        public bool? Partecipo { get; set; }
    }
}