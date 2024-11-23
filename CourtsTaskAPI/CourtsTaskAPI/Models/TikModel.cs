namespace CourtsTaskAPI.Models
{
    public class TikModel
    {

        public int? MisTik { get; set; }
        public string? Osek { get; set; }
        public string? SugTik { get; set; }
        public DateTime TkufatZakaaot { get; set; }
        public DateTime TarichPtichatTik { get; set; }
        public DateTime TarichDyun { get; set; }
        public string? MgishArar { get; set; }
        public string? Mshiva { get; set; }
        public string? YprVaada { get; set; }
        public string? Natzig { get; set; }
        public enumStatus Status { get; set; }


    }
    public enum enumStatus
    {
        niftach,
        paail ,
        sagur 
    }

}