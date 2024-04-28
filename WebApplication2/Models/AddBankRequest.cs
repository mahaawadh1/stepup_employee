namespace WebApplication2.Models
{
    public class AddBankRequest
    {
        public object Name { get; internal set; }
        public object Location { get; internal set; }
        public int EmployeeCount { get; internal set; }
        public string BranchManager { get; internal set; }
        public string LocationName { get; internal set; }
        public string LocationURL { get; internal set; }
    }
}