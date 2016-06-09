using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Reclamacao
    {
        //[Key]
        public int ReclamacaoID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Imagem { get; set; }

        //[ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }
        public int CategoriaID { get; set; }

        //[ForeignKey("UsuarioID")]
        //public virtual Usuario Usuario { get; set; }
        //[ForeignKey("CategoriaID")]
        public virtual Categoria Categoria { get; set; }
        //[ForeignKey("ComentarioId")]
        //public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}