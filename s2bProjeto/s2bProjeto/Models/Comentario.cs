using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    public class Comentario
    {
        #region "atributos"
        private string descricao;
        private string imagem;
        #endregion
        #region"construtores"
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

        #endregion
    }
}