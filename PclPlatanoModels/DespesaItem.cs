using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclPlatanoModels
{
    [Table("despesa_item")]
    class DespesaItem
    {
        [Key]
        [Column("idDespesaItem")]
        public int IdDespesaItem { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nomeDespesaItem")]
        public string NomeDespesaItem { get; set; }

        [Required]
        [Column("idDespesaGrupo")]
        public int IdDespesaGrupo { get; set; }


        [Column("dtCadastro")]
        public DateTime DtCadastro { get; set; }

        [Column("dtUltimaAlteracao")]
        public DateTime DtUltimaAlteracao { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }
    }
}
