using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PclPlatanoModels
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(15)]
        public string TelefoneFixo { get; set; }

        [Required]
        [MaxLength(15)]
        public string TelefoneCelular { get; set; }

        [Required]
        [MaxLength(8)]
        public string CodigoUsuario { get; set; }

        [MaxLength(150)]
        public string Senha { get; set; }

        [MaxLength(150)]
        public string EnderecoRua { get; set; }

        [MaxLength(50)]
        public string EnderecoNumero { get; set; }

        [MaxLength(50)]
        public string EnderecoComplemento { get; set; }

        [MaxLength(100)]
        public string EnderecoBairro { get; set; }

        [MaxLength(100)]
        public string EnderecoCidade { get; set; }

        [MaxLength(100)]
        public string EnderecoEstado { get; set; }
    }
}
