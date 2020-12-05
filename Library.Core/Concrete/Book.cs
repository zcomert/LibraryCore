using Library.Core.Abstract;
using System;

namespace Library.Core.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"{Title,-100} {Year,-10}";
        }
    }
}
