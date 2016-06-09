using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.DAL
{
    //public class ProjetoInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FinalContext>
    //{
    //    protected override void Seed(FinalContext context)
    //    {
    //        //base.Seed(context);
    //        var categoria = new List<Categoria>
    //        {
    //            new Categoria {CategoriaID=1, Titulo="Acessibilidade", Descricao="" },
    //            new Categoria {CategoriaID=2, Titulo="Água e esgoto", Descricao="" },
    //            new Categoria {CategoriaID=3, Titulo="Alagamento", Descricao="" },
    //            new Categoria {CategoriaID=4, Titulo="Árvore", Descricao="" },
    //            new Categoria {CategoriaID=5, Titulo="Bem público", Descricao="" },
    //            new Categoria {CategoriaID=6, Titulo="Buraco", Descricao="" },
    //            new Categoria {CategoriaID=7, Titulo="Ciclovia", Descricao="" },
    //            new Categoria {CategoriaID=8, Titulo="Comércio", Descricao="" },
    //            new Categoria {CategoriaID=9, Titulo="Educação", Descricao="" },
    //            new Categoria {CategoriaID=10, Titulo="Energia", Descricao="" },
    //            new Categoria {CategoriaID=11, Titulo="Iluminação", Descricao="" },
    //            new Categoria {CategoriaID=12, Titulo="Lixo", Descricao="" },
    //            new Categoria {CategoriaID=13, Titulo="Mato", Descricao="" },
    //            new Categoria {CategoriaID=14, Titulo="Obra", Descricao="" },
    //            new Categoria {CategoriaID=15, Titulo="Pedestre", Descricao="" },
    //            new Categoria {CategoriaID=16, Titulo="Pichação", Descricao="" },
    //            new Categoria {CategoriaID=17, Titulo="Poluição do ar", Descricao="" },
    //            new Categoria {CategoriaID=18, Titulo="Poluição sonora", Descricao="" },
    //            new Categoria {CategoriaID=19, Titulo="Poluição visual", Descricao="" },
    //            new Categoria {CategoriaID=20, Titulo="Queimada", Descricao="" },
    //            new Categoria {CategoriaID=21, Titulo="Saúde", Descricao="" },
    //            new Categoria {CategoriaID=22, Titulo="Segurança", Descricao="" },
    //            new Categoria {CategoriaID=23, Titulo="Social", Descricao="" },
    //            new Categoria {CategoriaID=24, Titulo="Transporte", Descricao="" },
    //            new Categoria {CategoriaID=25, Titulo="Trânsito", Descricao="" }
    //        };
    //        categoria.ForEach(c => context.CategoriaB.Add(c));
    //        context.SaveChanges();

    //        var usuarios = new List<Usuario>
    //        {
    //            new Usuario {UsuarioID=1, Nome="Administrador", Email="admin@s2b.pucrs.br", Senha="s2b", Adm=true, Office=false },
    //            new Usuario {UsuarioID=2, Nome="SMOV", Email="smov@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
    //            new Usuario {UsuarioID=3, Nome="SMAN", Email="sman@s2b.pucrs.br", Senha="s2b", Adm=false, Office=true },
    //            new Usuario {UsuarioID=4, Nome="Hugo", Email="hugo@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
    //            new Usuario {UsuarioID=5, Nome="Ze", Email="ze@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false },
    //            new Usuario {UsuarioID=6, Nome="Luis", Email="luis@s2b.pucrs.br", Senha="s2b", Adm=false, Office=false }
    //        };
    //        usuarios.ForEach(u => context.UsuarioB.Add(u));
    //        context.SaveChanges();

    //        var reclamacaos = new List<Reclamacao>
    //        {
    //            new Reclamacao {ReclamacaoID=1, UsuarioID=4, CategoriaID=1, Titulo="Titulo1", Descricao="Descricao1", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro1", Numero=1, Cep="94.400-000" },
    //            new Reclamacao {ReclamacaoID=2, UsuarioID=5, CategoriaID=2, Titulo="Titulo2", Descricao="Descricao2", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro2", Numero=1, Cep="94.400-000" },
    //            new Reclamacao {ReclamacaoID=3, UsuarioID=6, CategoriaID=3, Titulo="Titulo3", Descricao="Descricao3", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro3", Numero=1, Cep="94.400-000" }
    //            //new Reclamacao {ID=4, UsuarioID=4, CategoriaID=4, Titulo="Titulo4", Descricao="Descricao4", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro4", Numero=1, Cep="94.400-000" },
    //            //new Reclamacao {ID=5, UsuarioID=5, CategoriaID=5, Titulo="Titulo5", Descricao="Descricao5", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro5", Numero=1, Cep="94.400-000" },
    //            //new Reclamacao {ID=6, UsuarioID=6, CategoriaID=6, Titulo="Titulo6", Descricao="Descricao6", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro6", Numero=1, Cep="94.400-000" },
    //            //new Reclamacao {ID=7, UsuarioID=4, CategoriaID=7, Titulo="Titulo7", Descricao="Descricao7", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro7", Numero=1, Cep="94.400-000" },
    //            //new Reclamacao {ID=8, UsuarioID=5, CategoriaID=8, Titulo="Titulo8", Descricao="Descricao8", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro8", Numero=1, Cep="94.400-000" },
    //            //new Reclamacao {ID=9, UsuarioID=6, CategoriaID=9, Titulo="Titulo9", Descricao="Descricao9", Data=DateTime.Parse("2016-06-01"), Bairro="Centro", Logradouro="Logradouro9", Numero=1, Cep="94.400-000" }
    //        };
    //        reclamacaos.ForEach(r => context.ReclamacaoB.Add(r));
    //        context.SaveChanges();

    //        var comentario = new List<Comentario>
    //        {
    //            new Comentario { ComentarioID=1, UsuarioID=5, ReclamacaoID=1, Descricao="Descricao1" },
    //            new Comentario {ComentarioID=2, UsuarioID=6, ReclamacaoID=2, Descricao="Descricao2" },
    //            new Comentario {ComentarioID=3, UsuarioID=4, ReclamacaoID=3, Descricao="Descricao3" }
    //            //new Comentario {ID=4, UsuarioID=5, ReclamacaoID=1, Descricao="Descricao4" },
    //            //new Comentario {ID=5, UsuarioID=6, ReclamacaoID=1, Descricao="Descricao5" },
    //            //new Comentario {ID=6, UsuarioID=4, ReclamacaoID=1, Descricao="Descricao6" },
    //            //new Comentario {ID=7, UsuarioID=5, ReclamacaoID=1, Descricao="Descricao7" },
    //            //new Comentario {ID=8, UsuarioID=6, ReclamacaoID=1, Descricao="Descricao8" },
    //            //new Comentario {ID=9, UsuarioID=4, ReclamacaoID=1, Descricao="Descricao9" },
    //            //new Comentario {ID=10, UsuarioID=5, ReclamacaoID=1, Descricao="Descricao10" }
    //        };
    //        comentario.ForEach(co => context.ComentarioB.Add(co));
    //        context.SaveChanges();
    //    }
    //}
}