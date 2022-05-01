using DataAccessLayer.Concrete.Repositoriess;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstractt
{
    public interface IContentDal : IRepository<Content>
    {
    }
}
