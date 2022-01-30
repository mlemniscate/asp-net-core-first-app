using Session03DesignPatterns.AbstractFactory;
using Session03DesignPatterns.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns
{
    internal class Program
    {
        // before adapter
        //private static ILogger logger = new MyLogger();
        // after adapter
        private static ILogger logger = new SpecialLoggerAdapter();
        static void Main(string[] args)
        {
            /*IRepositoryFactory repositoryFactory = new SqlRepositoryFactory();
            ICategoryRepository categoryRepository = repositoryFactory.GetCategoryRepository();*/

            logger.Log();
        }
    }
}
