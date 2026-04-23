namespace Core.Application
{
    public record PlayslipQuery
    {
        public int TenantCode { get; set; }
        public int Earnings1 { get; set; }
        public int Earnings2 { get; set; }
    }
}
