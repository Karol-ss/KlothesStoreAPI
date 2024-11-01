using System.ComponentModel.DataAnnotations;

namespace KlothesAPI.Models
{
    public class Fornecedores
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
