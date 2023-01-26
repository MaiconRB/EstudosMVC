using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System;

namespace EstudosMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required (ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get;set; }

        
    }
}
