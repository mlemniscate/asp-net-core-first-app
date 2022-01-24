using System.Collections.Generic;

namespace Section2DesignPatterns.Infrastructure
{
    public interface IRepository
    {
        void Save();
        List<int> GetAll();
    }

    public class SqlRepository : IRepository
    {
        public List<int> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }

    public class InMemoryRepository : IRepository
    {
        public List<int> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }

    public class NullRepo : IRepository
    {
        public List<int> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IRepositoryFactory
    {
        IRepository CreateRepository(string environmentName);
    }

    public class Factory : IRepositoryFactory
    {
        public IRepository CreateRepository(string environmentName)
        {
            if (environmentName == "Development")
            {
                return new InMemoryRepository();
            }
            else if (environmentName == "xxx")
            {
                return new SqlRepository();
            } else
            {
                return new NullRepo();
            }
        }
    }
}
