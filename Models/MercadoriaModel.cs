using System.ComponentModel.DataAnnotations;

namespace LEKSupplyApplication.Models
{
    public class MercadoriaModel
    {
        public int Id { get; set; }

        //Validação dos campo
        [Required(ErrorMessage = "Digite o nome da mercadoria")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o número de registro da mercadoria")]
        public int NmrRegistro { get; set; }

        [Required(ErrorMessage = "Digite o nome do fabricante da mercadoria")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o tipo da mercadoria")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Digite uma descrição para a mercadoria")]
        public string Descricao { get; set; }
    }
}
