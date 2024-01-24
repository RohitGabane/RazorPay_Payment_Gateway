namespace Payment_Gateway.Models
{
    public class RazorPayOptionsModel
    {
        public string? Key { get; set; }
        public decimal AmountInSubUnits { get; set; }
        public string? Currency { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageLogUrl { get; set; }
        public string? OrderId { get; set; }
        public string? ProfileName { get; set; }
        public string? ProfileContact { get; set; }
        public string? ProfileEmail { get; set; }
        public Dictionary<string, string> Notes { get; set; }
    }
}