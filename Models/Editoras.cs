using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_GENIUS.Models
{
    [Table("BGENIUS_EDITORA")]
    public class Editoras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EditoraId { get; set; }

        [Required(ErrorMessage = "O nome da editora é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O país da editora é obrigatório.")]
        public string Pais { get; set; }

        // Relacionamento 1...N com Livro
        public ICollection<Livros> Livros { get; set; }
    }
}