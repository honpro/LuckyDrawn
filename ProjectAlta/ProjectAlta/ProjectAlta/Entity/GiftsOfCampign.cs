namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("GiftsOfCampign")]
    public partial class GiftsOfCampign
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiftsOfCampignID { get; set; }

        [StringLength(255)]
        public string GiftsOfCampignName { get; set; }

        [StringLength(255)]
        public string Discription { get; set; }

        public int? CodeCount { get; set; }

        public bool? Active { get; set; }

        public int? GiftsID { get; set; }

        public DateTime? ExpriredDate { get; set; }

        public Gift Gift { get; set; }
    }
}
