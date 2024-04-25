using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_GENIUS.Models
{
    [Table("BGENIUS_EMPRESTIMO")]
    public class Emprestimos
    {
        [Key]
        public int EmprestimoId { get; set; }

        [Required(ErrorMessage = "A data de empréstimo é obrigatória.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataEmprestimo { get; set; }

        [Required(ErrorMessage = "A data de devolução é obrigatória.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataDevolucao { get; set; }

        [Required(ErrorMessage = "O Id do livro é obrigatório.")]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "O Id do cliente é obrigatório.")]
        public int ClienteId { get; set; }

        // Relacionamento com Livro (1..N)
        [ForeignKey("LivroId")]
        public Livros Livro { get; set; }

        // Relacionamento com Cliente (1..N)
        [ForeignKey("ClienteId")]
        public Clientes Cliente { get; set; }
    }
}