using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSys
{
    using System.Collections.Generic;

    public class DiscountNotification
    {
        private Dictionary<string, List<ICustomer>> _subscribers = new();

        public Dictionary<string, List<ICustomer>> Subscribers => _subscribers;

        public void Subscribe(string category, ICustomer customer)
        {
            if (!_subscribers.ContainsKey(category))
            {
                _subscribers[category] = new List<ICustomer>();
            }

            if (!_subscribers[category].Contains(customer))
            {
                _subscribers[category].Add(customer);
                Console.WriteLine($"{((Customer)customer).Name} підписався на категорію '{category}'.");
            }
        }

        public void Unsubscribe(string category, ICustomer customer)
        {
            if (_subscribers.ContainsKey(category) && _subscribers[category].Contains(customer))
            {
                _subscribers[category].Remove(customer);
                Console.WriteLine($"{((Customer)customer).Name} відписався від категорії '{category}'.");
            }
        }

        public void Notify(string category, string message)
        {
            if (_subscribers.ContainsKey(category))
            {
                foreach (var customer in _subscribers[category])
                {
                    customer.Update(category, message);
                }
            }
        }
    }

}
