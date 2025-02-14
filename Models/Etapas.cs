using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Id da etapa")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Título da etapa")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano da etapa")]
        public string Ano { get; set; } = string.Empty;

    }
}
