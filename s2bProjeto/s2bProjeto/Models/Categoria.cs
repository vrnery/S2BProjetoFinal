using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    [Table("CATEGORIA")]
    public class Categoria
    {
        #region "atributos"
        private int categoriaId;
        private string titulo;
        private string descricao;
        [InverseProperty("UsuarioId")]
        private ICollection<Reclamacao> reclamacoes;
        #endregion

        #region "construtores"
        public Categoria() { }
        /// <summary>
        /// Construtor que recebe o nome
        public Categoria(string titulo, string descricao)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
        }
        #endregion

        #region "métodos públicos"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId
        {
            get { return categoriaId; }
            set { this.categoriaId = value; }
        }
        [Required(ErrorMessage = "Titulo é um campo obrigatório!")]
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }

        }
        [Required(ErrorMessage = "Descrição é um campo obrigatório!")]
        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }

        }
        public virtual ICollection<Reclamacao> Reclamacoes
        {
            get { return reclamacoes; }
            set { reclamacoes = value; }
        }
        #endregion
    }
}