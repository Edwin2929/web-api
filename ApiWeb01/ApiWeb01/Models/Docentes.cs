namespace ApiWeb01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Docentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iddocente { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string especialidad { get; set; }
    }
}
