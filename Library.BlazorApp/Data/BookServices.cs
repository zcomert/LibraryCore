using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using Library.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.BlazorApp.Data
{
    public  class BookServices
    {
        public Task<List<Book>> GetBooksAsync()
        {
            var bookService = InstanceFactory.GetInstance<IBookService>();
            return Task.FromResult(bookService.GetAll().ToList());
        }
    }
}
