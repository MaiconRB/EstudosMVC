using System.ComponentModel.DataAnnotations;

namespace EstudosMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
        //public List<Produto> Produtos { get; set; }

    }
}
