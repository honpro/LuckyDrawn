namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class RulesForGift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RulesForGiftsID { get; set; }

        [StringLength(255)]
        public string RulesForGiftsName { get; set; }

        [StringLength(255)]
        public string Schedule { get; set; }

        public TimeSpan? StartTime { get; set; }

        public int? Probability { get; set; }

        public TimeSpan? EndTime { get; set; }

        public bool? Active { get; set; }
    }
}
