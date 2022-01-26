using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.AbstractFactory
{
    public interface IRepositoryFactory
    {
        IPersonRepository GetPersonRepository();
        IProductRepository GetProductRepository();
        ICategoryRepository GetCategoryRepository();
    }

    public class SqlRepositoryFactory : IRepositoryFactory
    {
        public ICategoryRepository GetCategoryRepository()
        {
            return new SqlCategoryRepository();
        }

        public IPersonRepository GetPersonRepository()
        {
            return new SqlPersonRepository();
        }

        public IProductRepository GetProductRepository()
        {
            return new SqlProductRepository();
        }
    }

    public class InmemoryRepositoryFactory : IRepositoryFactory
    {
        public ICategoryRepository GetCategoryRepository()
        {
            return new InmemoryCategoryRepository();
        }

        public IPersonRepository GetPersonRepository()
        {
            return new InmemoryPersonRepository();
        }

        public IProductRepository GetProductRepository()
        {
            return new InmemoryProductRepository();
        }
    }
}
