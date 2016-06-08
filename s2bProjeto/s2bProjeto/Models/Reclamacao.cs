using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    [Table ("RECLAMACAO") ]
    public class Reclamacao
    {
        #region "atributos"
        private int reclamacaoId;
        private string titulo;
        private string descricao;
        private DateTime data;
        private string bairro;
        private string logradouro;
        private int numero;
        private string cep;
        private string imagem;
        private ICollection<Comentario> comentarios;
        private int usuarioId;
        private Usuario usuario;
        #endregion
        #region "construtores"
        public Reclamacao() { }
        /// <summary>
        /// Constutor classe Reclamacao titulo e descricao 
        /// </summary>
        /// <param string titulo="titulo"></param>
        /// <param string descricao="descricao"></param>
        public Reclamacao (string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;

        }
        /// <summary>
        ///Construtor classe Reclamacao todos atributos
        /// </summary>
        /// <param string titulo ="titulo"></param>
        /// <param string descricao="descricao"></param>
        /// <param Datetime data="data"></param>
        /// <param string bairro="bairro"></param>
        /// /// <param string logradouro="logradouro"></param>
        /// <param int numero="numero"></param>
        /// <param string cep="cep"></param>
        /// <param string imagem="imagem"></param>
        public Reclamacao (string titulo, string descricao, DateTime data, string bairro, string logradouro, int numero, string cep, string imagem): this (titulo, descricao)
        {
            Data = data;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Imagem = imagem;

        }
        #endregion
        #region "métodos públicos"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReclamacaoId
        {
            get { return reclamacaoId; }
            set { this.reclamacaoId = value; }
        }
        [Required]
        public string Titulo
        {
            get { return titulo; }
            set { this.titulo = value; }
        }
        [Required]
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }
        [Required]
        public DateTime Data
        {
            get { return data; }
            set { this.data = value; }
        }
        [Required]
        public string Bairro
        {
            get { return bairro; }
            set { this.bairro = value; }
        }
        [Required]
        public string Logradouro
        {
            get { return logradouro; }
            set { this.logradouro = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { this.numero = value; }
        }
        [RegularExpression  (@"^\d{5}-\d{3}$", ErrorMessage = "Cep Inválido") ]
        public string Cep
        {
            get { return cep; }
            set { this.cep = value; }
        }
        public string Imagem
        {
            get { return imagem; }
            set { this.imagem = value; }
        }
        public virtual ICollection<Comentario> Comentario
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        public int UsuarioId
        {
           get { return usuarioId; }
           set { usuarioId = value; }
     }
        [ForeignKey("UsuarioId")]
        [Column(Order = 1)]
        public virtual Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion
    }
}