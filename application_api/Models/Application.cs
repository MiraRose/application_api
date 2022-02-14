namespace application_api.Models
{
    public class Application
    {
        public long Id { get; set; }
        public string? BusinessName { get; set; }
        public string? Industry { get; set; }
        public string? Email { get; set; }
        public int AnnualSales { get; set; }
        public int AnnualPayroll { get; set; }
        public int NumOfEmployees { get; set; }
        public string? ZipCode { get; set; }
    }
}