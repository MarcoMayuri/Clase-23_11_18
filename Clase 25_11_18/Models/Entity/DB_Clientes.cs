namespace Clase_25_11_18.Models.Intity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB_Clientes : DbContext
    {
        public DB_Clientes()
            : base("name=DB_Clientes")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .Property(e => e.VNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.VDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.VRUC)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.VTelefono)
                .IsUnicode(false);
        }
    }
}
