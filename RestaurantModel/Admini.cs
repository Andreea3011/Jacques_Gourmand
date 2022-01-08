namespace RestaurantModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admini")]
    public partial class Admini
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminId { get; set; }

        [StringLength(50)]
        public string UserAdmin { get; set; }

        [StringLength(50)]
        public string ParolaAdmin { get; set; }
    }
}
