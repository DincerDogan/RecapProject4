using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entity.DTOs
{
   public class RentalDetailDto:IDto
    {
        public int CarId { get; set; }
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
    }
}
