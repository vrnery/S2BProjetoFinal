using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Usuario
    {
        //[Key]
        public int UsuarioID { get; set; }
        //[Required(ErrorMessage = "Nome é um campo obrigatório!")]
        //[StringLength(60, MinimumLength = 2, ErrorMessage = "O nome tem que possuir no minimo 3 e no maximo 60 caracteres!")]
        public string Nome { get; set; }
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail não é válido")]
        public string Email { get; set; }
        //[Required]
        //[StringLength(12, MinimumLength = 3, ErrorMessage = "A senha tem que possuir no minimo 6 e no maximo 12 caracteres!")]
        public string Senha { get; set; }
        public bool Adm { get; set; }
        public bool Office { get; set; }

        //[ForeignKey("ReclamacaoId")]
        public virtual ICollection<Reclamacao> Reclamacaos { get; set; }
    }
}