using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace s2bProjeto.Models
{
    public class BancoInicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<ModelContext>
    {
        protected override void Seed(ModelContext context)
        {
            //base.Seed(context);
            var categoria = new List<Categoria>
            {
                new Categoria {CategoriaId=1, Titulo="Acessibilidade", Descricao="Relatos sobre acessibilidade" }
            };
            categoria.ForEach(c => context.Categorias.Add(c));
            context.SaveChanges();

            var usuario = new List<Usuario>
            {
                new Usuario {UsuarioId=1, Nome="Administrador", Email="admin@s2b.pucrs.br", Senha="s2b", Adm=true, Office=false }
            };
            usuario.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();

            var reclamacao = new List<Reclamacao>
            {
                new Reclamacao {ReclamacaoId=1, UsuarioId=1, CategoriaId=1, Titulo="Falta de Acessibilidade", Descricao="Bfldkkd", Data=DateTime.Parse("2016-06-09"), Bairro="Centro", Logradouro="Rua dos Andradas", Numero=1223, Cep="94400-000" }
            };
            reclamacao.ForEach(r => context.Reclamacoes.Add(r));
            context.SaveChanges();

            var comentario = new List<Comentario>
            {
                new Comentario {ComentarioId=1, UsuarioId=1, ReclamacaoId=1, Descricao="Todas as criticas" }
            };
            comentario.ForEach(co => context.Comentarios.Add(co));
            context.SaveChanges();
        }
    }
}