namespace SkyCarsWebAPI.Models
{
    public class TrackingBookingModel: BaseModel
    {
        public string LocationName { get; set; }

        public bool IsDelete { get; set; }
    }
}
