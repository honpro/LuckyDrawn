namespace ProjectAlta.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Setting")]
    public partial class Setting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SettingID { get; set; }

        [StringLength(255)]
        public string QRCodeSetting { get; set; }

        [StringLength(255)]
        public string LandingPage { get; set; }

        [StringLength(255)]
        public string SMSText { get; set; }

        public TimeSpan? Time { get; set; }

        [StringLength(255)]
        public string SendtoMail { get; set; }
    }
}
