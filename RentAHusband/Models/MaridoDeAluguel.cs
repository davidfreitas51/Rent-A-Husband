using System.ComponentModel.DataAnnotations;

namespace RentAHusband.Models
{
    public class MaridoDeAluguel
    {
        [Key]
        public int Id { get; set; }
        public string Nome {  get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
