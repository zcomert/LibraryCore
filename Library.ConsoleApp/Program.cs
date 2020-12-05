using Library.Business.Abstract;
using Library.Business.Concrete;
using Library.Business.DependencyResolvers.Ninject;
using Library.Core.Concrete;
using Library.DataAccess.Concrete.EntityFrameworkCore;
using System;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookService = InstanceFactory.GetInstance<IBookService>();
            bookService.GetAll().ForEach(b => Console.WriteLine(b));
            Console.ReadKey();
        }
    }
}
