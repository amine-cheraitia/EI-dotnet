using System.ComponentModel.DataAnnotations;

namespace EI.Models
{
    public class Utilisateur
    {
        [Key]
        public string? Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Login { get; set; }
        public string? MotDePasse { get; set; }

    }
}
