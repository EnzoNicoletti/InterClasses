using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Jogador é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Jogador pode ter, no máximo, 50 caracteres.")]
        [Display(Name = "Nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Número do Jogador é Obrigatório")]
        [Range(1, 99, ErrorMessage = "O Número do Jogador deve estar entre 1 e 99.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Posição")]
        [MaxLength(30, ErrorMessage = "A Posição do Jogador pode ter, no máximo, 30 caracteres.")]
        public string? Posicao { get; set; }

        // Relacionamento com a Tabela Time
        [Display(Name = "Time")]
        public int TimeId { get; set; } // Vincular o campo do Id da tabela
        public Time? Time { get; set; } // Vincular o Ojeto relacionado ao Id acima
    }
}
