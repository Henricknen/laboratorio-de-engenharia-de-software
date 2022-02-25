using System.ComponentModel.DataAnnotations;

namespace Aplicaçao_web.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }         
        public string Descricao { get; set; }

    }
}
