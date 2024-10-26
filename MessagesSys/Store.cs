using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesSys
{
    public class Store
    {
        private readonly DiscountNotification _discountNotification = new();
        public List<string> Categories { get; }

        public Store()
        {
            Categories = new List<string> { "Смартфони", "Ноутбуки", "Аксесуари" };
        }

        // Метод для підписки клієнта на категорію
        public void SubscribeToCategory(string category, ICustomer customer)
        {
            _discountNotification.Subscribe(category, customer);
        }

        // Метод для відписки клієнта від категорії
        public void UnsubscribeFromCategory(string category, ICustomer customer)
        {
            _discountNotification.Unsubscribe(category, customer);
        }

        // Метод для сповіщення про знижку на конкретну категорію
        public void NotifyDiscounts(string category, string discountMessage)
        {
            Console.WriteLine($"Нова знижка у категорії '{category}': {discountMessage}");
            _discountNotification.Notify(category, discountMessage);
        }
    }
}
