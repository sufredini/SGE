using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Id das notas")]
        public int Id { get; set; }

        [ForeignKey("MateriasId")]
        [Display(Name = "Materias")]
        public int MateriasId { get; set; }
        public Materias? Materias { get; set; }

        [ForeignKey("AlunosId")]
        [Display(Name = "Alunos")]
        public int AlunosId { get; set; }
        public Alunos? Alunos { get; set; }

        [Column("Notas")]
        [Display(Name = "Notas")]
        public double Nota { get; set; }

    }
}
