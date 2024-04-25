using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BOOK_GENIUS.Models
{
    [Table("BGENIUS_LIVRO")]
    public class Livros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "O título do livro é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O ISBN do livro é obrigatório.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "A quantidade de páginas do livro é obrigatória.")]
        public int Paginas { get; set; }

        // Relacionamento 1...1 com Autor
        [ForeignKey("Autor")]
        public int AutorId { get; set; }
        public Autores Autor { get; set; }

        // Relacionamento 1...N com Editora
        [ForeignKey("Editora")]
        public int EditoraId { get; set; }
        public Editoras Editora { get; set; }

    }
}
