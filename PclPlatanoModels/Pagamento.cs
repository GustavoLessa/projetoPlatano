using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace PclPlatanoModels
{
    [Table("pagamento")]
    class Pagamento
    {
        [Key]
        [Column("idPagamento")]
        public int IdPagamento { get; set; }

        [MaxLength(500)]
        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("idDespesa")]
        public int IdDespesa { get; set; }

        [Column("dtPagamento")]
        public DateTime DtPagamento { get; set; }

        [Column("dtCadastro")]
        public DateTime DtCadastro { get; set; }

        [Column("dtUltimaAlteracao")]
        public DateTime DtUltimaAlteracao { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        

    }
}