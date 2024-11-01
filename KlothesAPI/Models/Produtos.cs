using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KlothesAPI.Models
{
    public class Produtos
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Estoque { get; set; }
        [ForeignKey("FornecedoresId")]
        public Guid FornecedoresId { get; set; }

        public Fornecedores? Fornecedores { get; set; }
    }
}
