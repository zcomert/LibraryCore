using Library.Core.Concrete;
using Library.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBookDal : 
        EfRepositoryBase<Book,LibraryDBContext>,
        IBookDal
    {

    }
}
