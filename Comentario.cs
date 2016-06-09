using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Comentario
    {
        //[Key]
        public int ComentarioID { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public int UsuarioID { get; set; }
        public int ReclamacaoID { get; set; }

        //[ForeignKey("UsuarioID")]
        public virtual Usuario Usuario { get; set; }
        public virtual Reclamacao Reclamacao { get; set; }
        
    }
}