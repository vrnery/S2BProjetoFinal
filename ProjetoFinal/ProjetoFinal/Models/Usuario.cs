using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Usuario
    {
        //#region "atributos"
        //private string nome;
        //private string email;
        //private string senha;
        //private Boolean adm;
        //private Boolean office;
        //#endregion

        //#region "construtores"
        //public Usuario() { }

        ///// <summary>
        ///// Construtor que recebe o nome
        //public Usuario(string nome)
        //{
        //    this.Nome = nome;
        //}

        ///// <summary>
        ///// construtor que recebe nome, email e senha
        ///// </summary>
        ///// <param nome string="nome"></param>
        ///// <param email string="email"></param>
        ///// <param senha string="senha"></param>
        //public Usuario(string nome, string email, string senha) : this(nome)
        //{
        //    this.Email = email;
        //    this.Senha = senha;
        //}

        ///// <summary>
        ///// construtor para todos atributos da classe Usuário (nome, email, senha se é administrador ou oficial)
        ///// </summary>
        ///// <param nome="nome"></param>
        ///// <param email="email"></param>
        ///// <param senha="senha"></param>
        ///// <param adiministrador true or false="adm"></param>
        ///// <param oficial true or false ="office"></param>
        //public Usuario(string nome, string email, string senha, Boolean adm, Boolean office) : this(nome, email, senha)
        //{
        //    this.Adm = adm;
        //    this.Office = office;
        //}
        //#endregion

        //#region "métodos públicos"
        //[Required(ErrorMessage = "Nome é um campo obrigatório!")]
        //public string Nome
        //{
        //    get { return this.nome; }
        //    set { this.nome = value; }
        //}
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail não é válido")]
        //public string Email
        //{
        //    get { return email; }
        //    set { this.email = value; }
        //}
        //[Required]
        //public string Senha
        //{
        //    get { return this.senha; }
        //    set { senha = value; }
        //}
        //public Boolean Adm
        //{
        //    get { return this.adm; }
        //    set { this.adm = value; }
        //}
        //public Boolean Office
        //{
        //    get { return office; }
        //    set { this.office = value; }
        //}
        //#endregion

        public int ID { get; set; }
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        public string Nome { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail não é válido")]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public Boolean Adm { get; set; }
        public Boolean Office { get; set; }

    }
}