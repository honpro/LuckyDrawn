namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Gift
    {
        
        public Gift()
        {
            GiftsOfCampigns = new HashSet<GiftsOfCampign>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GiftsID { get; set; }

        [StringLength(255)]
        public string GiftsName { get; set; }

        [StringLength(255)]
        public string Discription { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreaterDate { get; set; }

       
        public ICollection<GiftsOfCampign> GiftsOfCampigns { get; set; }
    }
}
