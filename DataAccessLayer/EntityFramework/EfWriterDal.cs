﻿using DataAccessLayer.Abstractt;
using DataAccessLayer.Concrete.Repositoriess;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal:GenericRepository<Writer>,IWriterDal
    {
    }
}
