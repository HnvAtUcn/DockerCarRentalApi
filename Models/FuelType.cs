using System;
using System.Collections.Generic;

namespace DockerCarRentalApi.Models
{
    public partial class FuelType
    {
        public FuelType()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string FuelTypeName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
