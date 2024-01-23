using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, NorthwindContext>, IEmployeeDal
    {

    }
}
