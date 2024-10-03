using System;

class Program
{
    static void Main()
    {
        //Task1
        string text1 = "Это первое предложение. Это второе предложение! А это третье предложение?";
        int sentenceCount = text1.SentenceCount();
        Console.WriteLine($"Количество предложений в тексте: {sentenceCount}");
        //Task2
        string text2 = "Anna went to the park. Bob saw a racecar. Did you see the level?";
        int count = text2.CountWordsWithSameStartAndEnd();
        Console.WriteLine($"Количество начинающихся и заканчивающихся слов на один и тот же символ: {count}");
        //Task3
        Backpack backpack = new Backpack("Черный", "Gucci", 1, 15.0);
        backpack.ItemAdded += (sender, e) => Console.WriteLine($"Добавлен объект: {e.Item.Name}");
        backpack.ItemRemoved += (sender, e) => Console.WriteLine($"Удален объект: {e.Item.Name}");

        Item book = new Item("Кросовки", 3);
        Item laptop = new Item("Форма", 1);

        backpack.AddItem(book);
        backpack.AddItem(laptop);
        backpack.RemoveItem(book);
    }
}
