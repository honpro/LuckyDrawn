namespace ProjectAlta.DTO
{
    public class SettingDTO
    {
        public int SettingID { get; set; }
        public string QRCodeSetting { get; set; }
        public string LandingPage { get; set; }
        public string SMSText { get; set; }
        public TimeSpan? Time { get; set; }
        public string SendtoMail { get; set; }
    }
}
