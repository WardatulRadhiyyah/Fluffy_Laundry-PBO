using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Fluffy_Laundry
{
    public partial class PelangganModel : DbContext
    {
        public PelangganModel()
            : base("name=PelangganModel")
        {
        }

        public virtual DbSet<Pelanggan> Pelanggans { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
