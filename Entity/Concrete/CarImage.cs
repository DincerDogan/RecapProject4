using System;
using System.Collections.Generic;
using System.Text;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class CarImage : IEntity
    {
        //public CarImage()
        //{
        //    Date=DateTime.now;
        //}
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
