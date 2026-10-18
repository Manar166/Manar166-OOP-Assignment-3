using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Course:IHasId
    {
        public Course(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
