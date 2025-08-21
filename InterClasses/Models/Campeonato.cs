using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Campeonato é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Campeonato pode ter, no máximo, 50 caracteres.")]
        [Display(Name = "Nome do Campeonato")]
        public string? Nome { get; set; }

        // Relacionamento Campeonato x Esporte
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }
        public Esporte? Esporte { get; set; }
    }
}
