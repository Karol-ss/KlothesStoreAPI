using System.ComponentModel.DataAnnotations;

namespace KlothesAPI.Models
{
    public class Vendas
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public ICollection<Produtos> Produtos { get; set; } = new List<Produtos>();

        public ICollection<Cliente> Cliente { get; set; } = new List<Cliente>();

    }
}
