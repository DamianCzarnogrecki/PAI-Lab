namespace LAB1.Server
{
    public class Kontekst : DbContext
    {
        public Kontekst(DbContextOptions<Kontekst> options) : base(options)
        {
        }

        public DbSet<Panstwo> Panstwo { get; set; }

        public DbSet<TypRzadu> TypRzadu { get; set; }
    }
}