using Library.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetProductsByCategory(int id);
        void Add(Book book);
        Book GetById(int Id);
        void Update(Book book);
    }
}
