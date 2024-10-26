using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSys
{
    public class Customer : ICustomer
    {
        public string Name { get;}
        public Customer(string name) { this.Name = name; }
        public Customer() { }

        public void Update(string category, string message)
        {
            Console.WriteLine($"Сповіщення для {Name}: {message} у категорії '{category}'.");
        }
    }
}
