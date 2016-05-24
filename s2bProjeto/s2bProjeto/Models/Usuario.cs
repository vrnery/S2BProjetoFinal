using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    public class Usuario
    {
        #region "atributos"
        private string nome;
        private string email;
        private string senha;
        private Boolean adm;
        private Boolean office;
        #endregion
        #region "construtores"
        public Usuario() { }
        public Usuario (string nome)
        {
            this.Nome = nome;
        }
        public Usuario (string nome, string email, string senha):this(nome)
        {            
            this.email = email;
            this.senha = senha;
        }
        public Usuario (string nome, string email, string senha, Boolean adm, Boolean office): this(nome, email, senha)
        {
            this.adm = adm;
            this.office = office;
        }
        #endregion
        #region "métodos públicos"
        public string Nome
        {
            get { return this.nome; }
            set
            {
                //try
                //{
                if (value == null)
                {
                    throw new System.ArgumentException("Nome Invalido!");
                }
                else
                {
                    this.nome = value;
                }
                
                    

                //}
                //catch (Exception ex)
                //{
                    //throw ex;
                //}
            }
        }
        public string Email {
            get { return email;}
            set { this.email = value;}
            }
        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
        public Boolean Adm {
            get { return this.adm; }
            set { this.adm = value; }
        }
        public Boolean Office {
            get { return office; }
            set {this.office = value; }
          }
               
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        public void validarUsuario (String nome, String email, String senha)
        {
            try
            {
                if(nome.Length > 2)
                {
                    this.nome = nome;
                }
                else
                    
                if(email.Contains("@"))
                    this.email = email;
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }
        #endregion


    }
}