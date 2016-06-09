using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    [Table ("USUARIO")]
    public class Usuario
    {
        #region "atributos"
        private int usuarioId;
        private string nome;
        private string email;
        private string senha;
        [InverseProperty("UsuarioId")]
        private ICollection<Reclamacao> reclamacoes;
        private ICollection<Comentario> comentarios;
        private Boolean adm;
        private Boolean office;
        private byte[] foto;
        private Boolean ativo;
        #endregion
        #region "construtores"
        public Usuario() { }
        /// <summary>
        /// Construtor que recebe o nome
        public Usuario(string nome)
        {
            this.Nome = nome;
            this.Ativo = true;
        }
        /// <summary>
        /// construtor que recebe nome, email e senha
        /// </summary>
        /// <param nome string="nome"></param>
        /// <param email string="email"></param>
        /// <param senha string="senha"></param>
        public Usuario(string nome, string email, string senha) : this(nome)
        {
            this.Email = email;
            this.Senha = senha;
        }
        /// <summary>
        /// construtor para todos atributos da classe Usuário (nome, email, senha se é administrador ou oficial)
        /// </summary>
        /// <param name="nome"></param>
        /// <param email="email"></param>
        /// <param senha="senha"></param>
        /// <param adiministrador true or false="adm"></param>
        /// <param oficial true or false ="office"></param>
        public Usuario(string nome, string email, string senha, Boolean adm, Boolean office) : this(nome, email, senha)
        {
            this.Adm = adm;
            this.Office = office;
        }
        public Usuario(string nome, string email, string senha, Boolean adm, Boolean office, byte[] foto, Boolean ativo) : this(nome, email, senha, adm, office)
        {
            this.Foto = foto;
            this.Ativo = ativo;
        }
        #endregion
        #region "métodos públicos"
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId
        {
            get { return usuarioId; }
            set { this.usuarioId = value; }
        }
        [Required(ErrorMessage ="Nome é um campo obrigatório!")]
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }

        }
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail não é válido")]        
        public string Email
        {
            get { return email; }
            set { this.email = value; }
            
        }
        [Required]
        public string Senha
        {
            get { return this.senha; }
            set { senha = value; }
        }
        public virtual ICollection <Comentario> Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        public virtual ICollection <Reclamacao> Reclamacoes
        {
            get { return reclamacoes; }
            set { reclamacoes = value; }
        }
       

        public Boolean Adm {
            get { return this.adm; }
            set { this.adm = value; }
        }
        public Boolean Office {
            get { return office; }
            set {this.office = value; }
          }
        public byte[] Foto
        {
            get { return this.foto; }
            set { this.foto = value; }
        }
        public Boolean Ativo
        {
            get { return this.ativo; }
            set { this.ativo = value; }
        }
                   
        #endregion


    }
}