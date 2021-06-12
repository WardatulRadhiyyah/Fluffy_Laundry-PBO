namespace Fluffy_Laundry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pelanggan")]
    public partial class Pelanggan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(20)]
        public string No_Hp { get; set; }

        public int Berat_Cucian { get; set; }

        [Required]
        [StringLength(10)]
        public string Jenis_Paket { get; set; }

        public double Harga_Paket { get; set; }

        public double Harga_Total { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tanggal_Pemsanan { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tanggal_Pengambilan { get; set; }
    }
}
