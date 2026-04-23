namespace Core.Modules.HR.CreateEmployee
{
    public record CreateEmployeeCommand
    {
        public required int Code { get; set; }
        public required string LastName { get; init; }
        public required string FirstName { get; init; }
        public required string LastNameKana { get; init; }
        public required string FirstNameKana { get; init; }
        public required DateOnly HireDate { get; init; }
    }
}
