using Microsoft.EntityFrameworkCore;

namespace Mission6_Underwood.Models
{
    public class FormContext: DbContext
    {

        public FormContext(DbContextOptions<FormContext> options) : base (options)
        {

        }
        public DbSet<Form> Forms { get; set; }

    }
}
