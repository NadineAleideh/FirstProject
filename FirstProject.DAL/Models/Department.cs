namespace FirstProject.DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
