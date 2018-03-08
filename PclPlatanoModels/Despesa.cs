using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PclPlatanoModels
{
    [Table("despesa")] //Uso de branchs, apenas para testar exemplo
    class Despesa
    {
        [Key]
        [Column("idDespesa")]
        public int IdDespesa { get; set; }
                
        [MaxLength(500)]
        [Column("descricao")]
        public string Descricao { get; set; }

        [Required]
        [Column("idDespesaItem")]
        public int IdDespesaItem { get; set; }

        [Required]        
        [Column("valorDespesa")]
        public decimal ValorDespesa { get; set; }

        [Column("dtCadastro")]
        public DateTime DtCadastro { get; set; }

        [Column("dtUltimaAlteracao")]
        public DateTime DtUltimaAlteracao { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }
    }
}
