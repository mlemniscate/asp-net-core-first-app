using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public interface ICloneable<T>
    {
        T Clone();
    }
    internal class PrototypeClass : ICloneable<PrototypeClass>
    {
        public PrototypeClass Clone()
        {
            return (PrototypeClass)this.MemberwiseClone();
        }
    }
}
