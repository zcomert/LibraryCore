using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Business.DependencyResolvers.Ninject;
using Library.Business.Abstract;

namespace Library.ASPCoreMVC.Controllers
{
    public class BookListController : Controller
    {
        public IActionResult Index()
        {
            var bookService = InstanceFactory.GetInstance<IBookService>();
            var list = bookService.GetAll();
            return View(list);
        }
    }
}
