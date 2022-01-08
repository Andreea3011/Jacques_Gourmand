namespace RestaurantModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meniu")]
    public partial class Meniu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MeniuId { get; set; }

        [StringLength(50)]
        public string Denumire { get; set; }

        [StringLength(50)]
        public string Categorie { get; set; }

        [StringLength(50)]
        public string Gramaj { get; set; }

        public int? Pret { get; set; }
    }
}
