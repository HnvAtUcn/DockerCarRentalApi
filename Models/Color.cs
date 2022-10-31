using System;
using System.Collections.Generic;

namespace DockerCarRentalApi.Models
{
    public partial class Color
    {
        public Color()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string ColorName { get; set; } = null!;
        public string ColorDescription { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
