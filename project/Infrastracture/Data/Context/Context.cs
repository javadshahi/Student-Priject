using Microsoft.EntityFrameworkCore;

public class Context:DbContext
  {
   public DbSet<Tbl_student> Tbl_Students { get; set; }
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
    optionsBuilder.UseSqlServer("server=.;Database=studentdb;trusted_connection=true;");
   }
   
  }