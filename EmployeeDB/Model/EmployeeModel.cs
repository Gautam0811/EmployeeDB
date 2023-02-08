namespace EmployeeDB
{
    public class EmployeeModel
    {
        public int id { get; set; }

        public string? Name { get; set; }

        public int Offers { get; set; }

        public int Quotes { get; set; }
        public int Orders { get; set; }

        public int Fullfilments { get; set; }
        public int Pickups { get; set; }

        public int AR { get; set; }
    }
}