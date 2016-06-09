using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BagProjeto.Models
{
    public class Categoria
    {
        //[Key]
        public int CategoriaID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        //[ForeignKey("ReclamacaoId")]
        public virtual ICollection<Reclamacao> Reclamacoes { get; set; }
    }
}