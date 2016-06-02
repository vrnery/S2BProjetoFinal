using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.DAL
{
    public class ProjetoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FinalContext>
    {
        protected override void Seed(FinalContext context)
        {
            //base.Seed(context);
            var categoria = new List<Categoria>
            {
                new Categoria {Titulo="Acessibilidade", Descricao="" },
                new Categoria {Titulo="Água e esgoto", Descricao="" },
                new Categoria {Titulo="Alagamento", Descricao="" },
                new Categoria {Titulo="Árvore", Descricao="" },
                new Categoria {Titulo="Bem público", Descricao="" },
                new Categoria {Titulo="Buraco", Descricao="" },
                new Categoria {Titulo="Ciclovia", Descricao="" },
                new Categoria {Titulo="Comércio", Descricao="" },
                new Categoria {Titulo="Educação", Descricao="" },
                new Categoria {Titulo="Energia", Descricao="" },
                new Categoria {Titulo="Iluminação", Descricao="" },
                new Categoria {Titulo="Lixo", Descricao="" },
                new Categoria {Titulo="Mato", Descricao="" },
                new Categoria {Titulo="Obra", Descricao="" },
                new Categoria {Titulo="Pedestre", Descricao="" },
                new Categoria {Titulo="Pichação", Descricao="" },
                new Categoria {Titulo="Poluição do ar", Descricao="" },
                new Categoria {Titulo="Poluição sonora", Descricao="" },
                new Categoria {Titulo="Poluição visual", Descricao="" },
                new Categoria {Titulo="Queimada", Descricao="" },
                new Categoria {Titulo="Saúde", Descricao="" },
                new Categoria {Titulo="Segurança", Descricao="" },
                new Categoria {Titulo="Social", Descricao="" },
                new Categoria {Titulo="Transporte", Descricao="" },
                new Categoria {Titulo="Trânsito", Descricao="" }
            };
            categoria.ForEach(c => context.Categorias.Add(c));
            context.SaveChanges();

            var usuario = new List<Usuario>
            {
                new Usuario {Nome="Administrador", Email="admin@s2b.pucrs.br", Senha="s2b", Adm=true, Office=false },
                new Usuario {Nome="SMOV", Email="smov@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
                new Usuario {Nome="SMAN", Email="sman@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
                new Usuario {Nome="Hugo", Email="hugo@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
                new Usuario {Nome="Ze", Email="ze@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
                new Usuario {Nome="Luis", Email="luis@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false }
            };
            usuario.ForEach(u => context.Usuario.Add(u));
            context.SaveChanges();

            var reclamacao = new List<Reclamacao>
            {
                new Reclamacao {UsuarioID=4, CategoriaID=1, Titulo="Titulo1", Descricao="Descricao1", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro1", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=5, CategoriaID=2, Titulo="Titulo2", Descricao="Descricao2", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro2", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=6, CategoriaID=3, Titulo="Titulo3", Descricao="Descricao3", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro3", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=4, CategoriaID=4, Titulo="Titulo4", Descricao="Descricao4", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro4", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=5, CategoriaID=5, Titulo="Titulo5", Descricao="Descricao5", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro5", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=6, CategoriaID=6, Titulo="Titulo6", Descricao="Descricao6", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro6", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=4, CategoriaID=7, Titulo="Titulo7", Descricao="Descricao7", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro7", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=5, CategoriaID=8, Titulo="Titulo8", Descricao="Descricao8", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro8", Numero=1, Cep="94.400-000" },
                new Reclamacao {UsuarioID=6, CategoriaID=9, Titulo="Titulo9", Descricao="Descricao9", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro9", Numero=1, Cep="94.400-000" }
            };
            reclamacao.ForEach(r => context.Reclamacoes.Add(r));
            context.SaveChanges();

            var comentario = new List<Comentario>
            {
                new Comentario {UsuarioID=5, ReclamacaoID=1, Descricao="Descricao1" },
                new Comentario {UsuarioID=6, ReclamacaoID=1, Descricao="Descricao2" },
                new Comentario {UsuarioID=4, ReclamacaoID=1, Descricao="Descricao3" },
                new Comentario {UsuarioID=5, ReclamacaoID=1, Descricao="Descricao4" },
                new Comentario {UsuarioID=6, ReclamacaoID=1, Descricao="Descricao5" },
                new Comentario {UsuarioID=4, ReclamacaoID=1, Descricao="Descricao6" },
                new Comentario {UsuarioID=5, ReclamacaoID=1, Descricao="Descricao7" },
                new Comentario {UsuarioID=6, ReclamacaoID=1, Descricao="Descricao8" },
                new Comentario {UsuarioID=4, ReclamacaoID=1, Descricao="Descricao9" },
                new Comentario {UsuarioID=5, ReclamacaoID=1, Descricao="Descricao10" }
            };
            comentario.ForEach(c => context.Comentarios.Add(c));
            context.SaveChanges();
        }
    }
}