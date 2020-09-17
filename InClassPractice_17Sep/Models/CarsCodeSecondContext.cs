using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace InClassPractice_17Sep.Models
{
    public partial class CarsCodeSecondContext : DbContext
    {
        public CarsCodeSecondContext()
        {
        }
        public CarsCodeSecondContext(DbContextOptions<CarsCodeSecondContext> options) : base(options)
        {

        }
        // Called when we're configuring a database connection.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                // Initialize the connection to a MySQL server.
                optionsBuilder
                   .UseMySql("server=localhost;port=3306;user=root;database=code_first_cars",
                       // Retreived from PHPMyAdmin under Home > Database Server > Server Version.
                       x => x.ServerVersion("10.4.14-MariaDB"));

                /*
                    Connection strings are used to define an entire connection profile in one string. They are composed of attributes and values separated by semicolons.
                    
                    server=VALUE - Declares the server address for the connection.
                    port=VALUE - Declares the port for the conenction.
                    user=VALUE - Declares the database username for the connection.
                    password=VALUE - Declares that username's password for the connection (if applicable).
                    database=VALUE - Declares the database name to connect to.
                */

                // server=localhost;port=3306;user=root;database=code_first_cars
            }
        }

        // Called when we're doing database migrations, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// Declare advanced column configuration for our model.
            modelBuilder.Entity<CodeSecondCar>(entity =>
            {
                // If you have foreign keys, declare them here as "HasIndex".

                // Declare the string encoding for our text fields.
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasData(
                     new CodeSecondCar()
                     {
                         ID = 1,
                         Name = "Chevrolet",
                         YearFounded = 1911
                     });
             entity.HasData(
                   new CodeSecondCar()
                   {
                       ID = 2,
                       Name = "Tesla",
                       YearFounded = null
                   },
                   new CodeSecondCar()
                   {
                       ID = 3,
                       Name = "Dodge",
                       YearFounded = null
                   },
                  
                   new CodeSecondCar()
                   {
                       ID = 4,
                       Name = "Toyota",
                       YearFounded = 1937
                   },
                   new CodeSecondCar()
                   {
                       ID = 5,
                       Name = "Honda",
                       YearFounded = 1946
                   },
                   new CodeSecondCar()
                   {
                       ID = 6,
                       Name = "Mitsubishi",
                       YearFounded = null
                   },
                   new CodeSecondCar()
                   {
                       ID = 7,
                       Name = "Nissan",
                       YearFounded = null
                   }

                   );
            });
            // Call the partial method in case we add some stuff to another file later.
            OnModelCreatingPartial(modelBuilder);
        }

        // Not technically needed, but the scaffolding generates it for later use, so we can add it if we want for future-proofing.
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}      
      