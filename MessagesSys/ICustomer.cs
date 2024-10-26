using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSys
{
    public interface ICustomer
    {
        void Update(string category, string message);
    }
}
