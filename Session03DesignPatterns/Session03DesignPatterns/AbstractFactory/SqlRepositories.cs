using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.AbstractFactory
{
    public class SqlPersonRepository : IPersonRepository
    {
    }
    public class SqlCategoryRepository : ICategoryRepository
    {
    }
    public class SqlProductRepository : IProductRepository
    {
    }
    public class InmemoryPersonRepository : IPersonRepository
    {
    }
    public class InmemoryCategoryRepository : ICategoryRepository
    {
    }
    public class InmemoryProductRepository : IProductRepository
    {
    }

}
