using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Models
{
    public class Comentario
    {
        //#region "atributos"
        //private string descricao;
        //private string imagem;
        //#endregion

        //#region"construtores"
        //public Comentario() { }
        ///// <summary>
        ///// Contrutor classe Comentario para todos atributos
        ///// </summary>
        ///// <param string descricao="descricao"></param>
        ///// <param string imagem="imagem"></param>
        //public Comentario(string descricao, string imagem)
        //{
        //    Descricao = descricao;
        //    Imagem = imagem;
        //}
        //#endregion

        //#region "metodos publicos"
        //public int ID { get; set; }
        //public string Descricao
        //{
        //    get { return descricao; }
        //    set { this.descricao = value; }
        //}
        //public string Imagem
        //{
        //    get { return imagem; }
        //    set { this.imagem = value; }
        //}
        //public int UsuarioID { get; set; }
        //public int ReclamacaoID { get; set; }
        //public virtual Usuario Usuario { get; set; }
        //public virtual Reclamacao Reclamacao { get; set; }
        //#endregion
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public int ReclamacaoID { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        
        public virtual Usuario Usuario { get; set; }
        public virtual Reclamacao Reclamacao { get; set; }
    }
}