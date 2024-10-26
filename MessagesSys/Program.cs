using MessagesSys;

Store store = new();
Customer oleg = new("Олег");
Customer victoria = new("Вікторія");

store.SubscribeToCategory("Смартфони", oleg);
store.SubscribeToCategory("Ноутбуки", oleg);
store.SubscribeToCategory("Ноутбуки", victoria);

store.NotifyDiscounts("Ноутбуки", "Знижка 15%");

store.UnsubscribeFromCategory("Ноутбуки", oleg);

store.NotifyDiscounts("Смартфони", "Знижка 10%");