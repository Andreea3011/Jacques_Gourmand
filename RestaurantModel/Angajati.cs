namespace RestaurantModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Angajati")]
    public partial class Angajati
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AngajatId { get; set; }

        [StringLength(50)]
        public string Nume { get; set; }

        [StringLength(50)]
        public string Prenume { get; set; }

        [StringLength(50)]
        public string NrTelefon { get; set; }

        [StringLength(50)]
        public string Functie { get; set; }

        [StringLength(50)]
        public string Norma { get; set; }

        public int? Salariu { get; set; }

        public int? OreSupl { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [StringLength(50)]
        public string Parola { get; set; }
    }
}
