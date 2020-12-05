using Library.Business.Abstract;
using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business.Concrete
{
    public class BookManager : IBookService
    {

        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public Book GetById(int Id)
        {
            return _bookDal.Get(b => b.Id == Id);
        }

        public List<Book> GetProductsByCategory(int id)
        {
            return _bookDal
                .GetAll()
                .Where(b => b.CategoryId == id)
                .ToList();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
