using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.Proxy
{
    public interface IRepository
    {
        List<string> GetAll();
    }
    public class Repository : IRepository
    {
        public virtual List<string> GetAll()
        {
            return new List<string>
            {
                "Milad Abdi",
                "Mehran Abdi"
            };
        }
    }

    public class CacheRepository : Repository, IRepository
    {
        public override List<string> GetAll()
        {
            // Check to know that is there any object in cache
            if(1!=1)
            {
                // put the object in cache
                var temp = base.GetAll();
            }
            // return object from cache 
            return new List<string>();
        }
    }
}
