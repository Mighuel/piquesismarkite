namespace MvcPiqueSysMarket.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBMarket : DbContext
    {
        public DBMarket()
            : base("name=DBMarket")
        {
        }

        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.SENHA)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<MvcPiqueSysMarket.Models.CARRINHO> CARRINHOes { get; set; }
    }
}
