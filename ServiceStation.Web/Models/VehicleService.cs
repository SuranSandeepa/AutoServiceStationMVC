namespace ServiceStation.Web.Models
{
    public class VehicleService
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
