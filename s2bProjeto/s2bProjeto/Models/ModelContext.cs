namespace s2bProjeto.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModeCOntext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 's2bProjeto.Models.Modelontext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
       public ModelContext()
          : base("name=s2bContext")
        {

        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Reclamacao> Reclamacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }



    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}