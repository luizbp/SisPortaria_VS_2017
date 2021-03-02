namespace SisPortaria.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PortDB : DbContext
    {
        public PortDB()
            : base("name=PortDB")
        {
        }

        public virtual DbSet<login> login { get; set; }
        public virtual DbSet<login1> login1 { get; set; }
        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<verificacao> verificacao { get; set; }
        public virtual DbSet<visitas> visitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<login>()
                .Property(e => e.LOGIN1)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.ATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.DELETADO)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.ADMIN)
                .IsUnicode(false);

            modelBuilder.Entity<login1>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<login1>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<login1>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.SEXO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.DT_NASCIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.ATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.DELETADO)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.visitas)
                .WithOptional(e => e.pessoa)
                .HasForeignKey(e => e.IDPESSOA);

            modelBuilder.Entity<verificacao>()
                .Property(e => e.P_LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.HR_ENTRADA)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.HR_SAIDA)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.ANDAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.LOCAL_VISITA)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.MOTIVO)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.ATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<visitas>()
                .Property(e => e.DELETADO)
                .IsUnicode(false);
        }
    }
}
