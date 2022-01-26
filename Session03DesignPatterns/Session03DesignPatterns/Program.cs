﻿using Session03DesignPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositoryFactory repositoryFactory = new SqlRepositoryFactory();
            ICategoryRepository categoryRepository = repositoryFactory.GetCategoryRepository();

        }
    }
}
