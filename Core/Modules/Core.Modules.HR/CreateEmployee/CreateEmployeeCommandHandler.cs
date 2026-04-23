namespace Core.Modules.HR.CreateEmployee
{
    public class CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
    {
        public async Task<Guid> Handle(CreateEmployeeCommand command)
        {
            var employeeId = Guid.CreateVersion7();

            await employeeRepository.Save();

            return employeeId;
        }
    }
}
