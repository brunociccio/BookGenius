using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOOK_GENIUS.Models;

[Table("BGENIUS_AUTOR")]
public class Autores
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AutorId { get; set; }

    [Required(ErrorMessage = "O nome do autor é obrigatório.")]
    public string Nome { get; set; }

    [StringLength(100, ErrorMessage = "A biografia do autor não pode ter mais de 100 caracteres.")]
    public string Biografia { get; set; }

    // Relacionamento 1...1 com Livro
    public Livros Livro { get; set; }
}

