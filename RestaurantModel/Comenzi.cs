namespace RestaurantModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comenzi")]
    public partial class Comenzi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComandaId { get; set; }

        public int? ClientId { get; set; }

        public int? MeniuId { get; set; }

        [StringLength(50)]
        public string Bucati { get; set; }
    }
}
