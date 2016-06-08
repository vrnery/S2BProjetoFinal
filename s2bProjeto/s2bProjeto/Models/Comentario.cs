using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    [Table ("COMENTARIOS")]
    public class Comentario
    {
        #region "atributos"
        private int comentarioId;
        private string descricao;
        private string imagem;
        private int reclamacaoId;
        private int usuarioId;
        private Usuario usuario;
        private Reclamacao reclamacao;
        #endregion
        #region"construtores"
        public Comentario()
        {
        
        }
        /// <summary>
        /// Contrutor classe Comentario para todos atributos
        /// </summary>
        /// <param string descricao="descricao"></param>
        /// <param string imagem="imagem"></param>
        public Comentario(string descricao, string imagem)
        {
            Descricao = descricao;
            Imagem = imagem;
        }
        #endregion
        #region "metodos publicos"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComentarioId
        {
            get { return comentarioId; }
            set { comentarioId = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }
        public string Imagem
        {
            get { return imagem; }
            set { this.imagem = value; }
        }
  
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int UsuarioId
        {
           get { return usuarioId; }
           set { usuarioId = value; }
        }
          public int ReclamacaoId
        {
           get { return reclamacaoId; }
            set { reclamacaoId = value; }

        }

       
        [ForeignKey("ReclamacaoId")]
        public virtual Reclamacao Reclamacao
        {
            get { return reclamacao; }
            set { reclamacao = value; }
        }

        #endregion
    }
}