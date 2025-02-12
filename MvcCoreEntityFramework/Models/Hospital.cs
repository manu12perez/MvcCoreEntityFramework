using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreEntityFramework.Models
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        [Column("Hospital_cod")]
        public int IdHospital { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Direccion")]
        public string Direccion { get; set; }

        [Column("Telefono")]
        public string Telefono { get; set; }

        [Column("Num_cama")]
        public int Camas { get; set; }
    }
}
