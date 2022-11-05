using Dictionary;
Dictionary1 dic = new Dictionary1();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Меню.");
    Console.WriteLine();
    Console.WriteLine("1. Ввести слово");
    Console.WriteLine("2. Просмотреть словарь");
    Console.WriteLine("3. Проверить наличие перевода слова");
    Console.WriteLine("4. Удалить слово и его перевод");
    Console.WriteLine("5. Изменить перевод слова по ключу");
    Console.WriteLine("6. Добавить перевод к слову");
    Console.WriteLine("7. Удалить перевод слова");
}
void GetMenu()
{
    string menu1 = Console.ReadLine();
    bool parse = int.TryParse(menu1, out var menu);
    if (parse)
    {
        switch (menu)
        {
            case 1:
                string select = Console.ReadLine();
                dic.CheckSelect(select);
                break;
            case 2:
                dic.ChechDictionary();
                break;
            case 3:
                dic.CheckTranslate();
                break;
            case 4:
                dic.DeleteDictionary();
                break;
            case 5:
                dic.ChangeKey();
                break;
            case 6:
                dic.AddTranslate();
                break;
            case 7:
                dic.DeleteTranslate();
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Введите пункт из меню");
                Console.WriteLine();
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
    }
}
while (true)
{
    Menu();
    GetMenu();
}
