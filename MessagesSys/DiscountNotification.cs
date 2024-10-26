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
        // Словник для зберігання підписників за категоріями
        private readonly Dictionary<string, List<ICustomer>> _subscribers = new();

        // Властивість для доступу до підписок (лише для читання)
        public IReadOnlyDictionary<string, List<ICustomer>> Subscribers => _subscribers;

        // Метод для підписки клієнта на конкретну категорію
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

        // Метод для відписки клієнта від конкретної категорії
        public void Unsubscribe(string category, ICustomer customer)
        {
            if (_subscribers.ContainsKey(category) && _subscribers[category].Contains(customer))
            {
                _subscribers[category].Remove(customer);
                Console.WriteLine($"{((Customer)customer).Name} відписався від категорії '{category}'.");
            }
        }

        // Метод для надсилання сповіщення всім підписникам конкретної категорії
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
