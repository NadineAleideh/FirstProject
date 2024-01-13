namespace FirstProject.DAL.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<Developer> Developers { get; set; } = new HashSet<Developer>();


    }
}
