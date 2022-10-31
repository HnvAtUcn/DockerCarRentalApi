using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DockerCarRentalApi.Models;

namespace DockerCarRentalApi.Data
{
    public class DockerCarRentalApiContext : DbContext
    {
        public DockerCarRentalApiContext (DbContextOptions<DockerCarRentalApiContext> options)
            : base(options)
        {
        }

        public DbSet<DockerCarRentalApi.Models.Car> Car { get; set; } = default!;

        public DbSet<DockerCarRentalApi.Models.Color> Color { get; set; }

        public DbSet<DockerCarRentalApi.Models.FuelType> FuelType { get; set; }

        public DbSet<DockerCarRentalApi.Models.Location> Location { get; set; }
    }
}
