namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int VehicleServiceId { get; set; }
        public string EmployeeId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public TransactionStatus Status { get; set; } = TransactionStatus.New;

    }
}
