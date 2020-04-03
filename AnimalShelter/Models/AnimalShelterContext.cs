using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Alfie", Type = "Cat", Age = 7, Gender = "Male" },
                new Animal { AnimalId = 2, Name = "Cheetah", Type = "Cat", Age = 6, Gender = "Female" },
                new Animal { AnimalId = 3, Name = "Spike", Type = "Ferret", Age = 2, Gender = "Female" },
                new Animal { AnimalId = 4, Name = "Mars", Type = "Cat", Age = 1, Gender = "Male" },
                new Animal { AnimalId = 5, Name = "Leila", Type = "Dog", Age = 2, Gender = "Female" },
                new Animal { AnimalId = 6, Name = "Lenny", Type = "Guinea Pig", Age = 1, Gender = "Male" }

            );
        }
    }
    
}