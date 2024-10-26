using MessagesSys;

Store store = new();
Customer oleg = new("Олег");
Customer victoria = new("Вікторія");

// Підписка клієнтів на категорії
store.SubscribeToCategory("Смартфони", oleg);
store.SubscribeToCategory("Ноутбуки", oleg);
store.SubscribeToCategory("Ноутбуки", victoria);

// Сповіщення про знижку на ноутбуки (отримають Олег і Вікторія)
store.NotifyDiscounts("Ноутбуки", "Знижка 15%");

// Олег відписується від категорії "Ноутбуки"
store.UnsubscribeFromCategory("Ноутбуки", oleg);

store.NotifyDiscounts("Смартфони", "Знижка 10%");