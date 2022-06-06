namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("TimeFrame")]
    public class TimeFrame
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeFrameID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
