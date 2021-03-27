using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entity.DTOs
{
    //DTO : Data Transformation Object
    public class CarDetailDto:IDto
    {
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public int Id { get; set; }
       public int ModelYear { get; set; }
    }
}
