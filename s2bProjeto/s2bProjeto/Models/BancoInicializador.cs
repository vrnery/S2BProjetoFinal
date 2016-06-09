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
                new Categoria {CategoriaId=1, Titulo="Acessibilidade", Descricao="Relatos sobre acessibilidade" },
                new Categoria {CategoriaId=2, Titulo="Água e esgoto", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=3, Titulo="Alagamento", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=4, Titulo="Árvore", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=5, Titulo="Bem público", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=6, Titulo="Buraco", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=7, Titulo="Ciclovia", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=8, Titulo="Comércio", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=9, Titulo="Educação", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=10, Titulo="Energia", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=11, Titulo="Iluminação", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=12, Titulo="Lixo", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=13, Titulo="Mato", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=14, Titulo="Obra", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=15, Titulo="Pedestre", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=16, Titulo="Pichação", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=17, Titulo="Poluição do ar", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=18, Titulo="Poluição sonora", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=19, Titulo="Poluição visual", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=20, Titulo="Queimada", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=21, Titulo="Saúde", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=22, Titulo="Segurança", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=23, Titulo="Social", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=24, Titulo="Transporte", Descricao="Relatos sobre" },
                new Categoria {CategoriaId=25, Titulo="Trânsito", Descricao="Relatos sobre" }
            };
            categoria.ForEach(c => context.Categorias.Add(c));
            context.SaveChanges();

            var usuario = new List<Usuario>
            {
                new Usuario {UsuarioId=1, Nome="Administrador", Email="admin@s2b.pucrs.br", Senha="s2b", Adm=true, Office=false },
                new Usuario {UsuarioId=2, Nome="SMOV", Email="smov@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
                new Usuario {UsuarioId=3, Nome="SMAN", Email="sman@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
                new Usuario {UsuarioId=4, Nome="Hugo", Email="hugo@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
                new Usuario {UsuarioId=5, Nome="Ze", Email="ze@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
                new Usuario {UsuarioId=6, Nome="Luis", Email="luis@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false }
            };
            usuario.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();

            var reclamacao = new List<Reclamacao>
            {
                new Reclamacao {ReclamacaoId=1, UsuarioId=1, CategoriaId=1, Titulo="Falta de Acessibilidade", Descricao="Bfldkkd", Data=DateTime.Parse("2016-06-09"), Bairro="Centro", Logradouro="Rua dos Andradas", Numero=1223, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=2, UsuarioId=5, CategoriaId=2, Titulo="Titulo2", Descricao="Descricao2", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro2", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=3, UsuarioId=6, CategoriaId=3, Titulo="Titulo3", Descricao="Descricao3", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro3", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=4, UsuarioId=4, CategoriaId=4, Titulo="Titulo4", Descricao="Descricao4", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro4", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=5, UsuarioId=5, CategoriaId=5, Titulo="Titulo5", Descricao="Descricao5", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro5", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=6, UsuarioId=6, CategoriaId=6, Titulo="Titulo6", Descricao="Descricao6", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro6", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=7, UsuarioId=4, CategoriaId=7, Titulo="Titulo7", Descricao="Descricao7", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro7", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=8, UsuarioId=5, CategoriaId=8, Titulo="Titulo8", Descricao="Descricao8", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro8", Numero=1, Cep="94400-000" },
                new Reclamacao {ReclamacaoId=9, UsuarioId=6, CategoriaId=9, Titulo="Titulo9", Descricao="Descricao9", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro9", Numero=1, Cep="94400-000" }
            };
            reclamacao.ForEach(r => context.Reclamacoes.Add(r));
            context.SaveChanges();

            var comentario = new List<Comentario>
            {
                new Comentario {ComentarioId=1, UsuarioId=1, ReclamacaoId=1, Descricao="Todas as criticas" },
                new Comentario {ComentarioId=2, UsuarioId=6, ReclamacaoId=2, Descricao="Descricao2" },
                new Comentario {ComentarioId=3, UsuarioId=4, ReclamacaoId=3, Descricao="Descricao3" },
                new Comentario {ComentarioId=4, UsuarioId=5, ReclamacaoId=1, Descricao="Descricao4" },
                new Comentario {ComentarioId=5, UsuarioId=6, ReclamacaoId=1, Descricao="Descricao5" },
                new Comentario {ComentarioId=6, UsuarioId=4, ReclamacaoId=1, Descricao="Descricao6" },
                new Comentario {ComentarioId=7, UsuarioId=5, ReclamacaoId=1, Descricao="Descricao7" },
                new Comentario {ComentarioId=8, UsuarioId=6, ReclamacaoId=1, Descricao="Descricao8" },
                new Comentario {ComentarioId=9, UsuarioId=4, ReclamacaoId=1, Descricao="Descricao9" },
                new Comentario {ComentarioId=10, UsuarioId=5, ReclamacaoId=1, Descricao="Descricao10" }
            };
            comentario.ForEach(co => context.Comentarios.Add(co));
            context.SaveChanges();
        }
    }
}