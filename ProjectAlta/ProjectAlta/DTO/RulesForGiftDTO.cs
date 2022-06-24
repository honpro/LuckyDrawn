namespace ProjectAlta.DTO
{
    public class RulesForGiftDTO
    {
        public int RulesForGiftsID { get; set; }
        public string RulesForGiftsName { get; set; }
        public string Schedule { get; set; }
        public TimeSpan? StartTime { get; set; }
        public int? Probability { get; set; }
        public TimeSpan? EndTime { get; set; }
        public bool? Active { get; set; }
    }
}
