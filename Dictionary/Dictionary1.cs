using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary;

public class Dictionary1
{
    private Dictionary<string,string> _dictionary;
    public Dictionary1()
    {
        _dictionary = new Dictionary<string, string>();
    }
    public void CheckSelect(string select)
    {
        bool check = _dictionary.ContainsKey(select);
        if (check)
        {
            Console.WriteLine();
            Console.WriteLine("Такое слово есть");
            Console.WriteLine();
            return;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Введите перевод этого слова");
            string translate = Console.ReadLine();
            Console.WriteLine();
            bool checks = _dictionary.TryAdd(select, translate);
            if (checks)
            {
                Console.WriteLine();
                Console.WriteLine("Слово добавлено в словарь");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка добавления");
                Console.WriteLine();
            }
        }
    }
    public void ChechDictionary()
    {
        if (_dictionary.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Словарь пуст");
            Console.WriteLine();
        }
        else
        {
            foreach (var dict in _dictionary)
            {
                Console.WriteLine($"Перевод(ы) слова {dict.Key} - {dict.Value}");
            }
        }
    }
    public void CheckTranslate()
    {
        if (_dictionary.Count != 0)
        {
            Console.WriteLine("Введите слово, перевод которого вы хотите посмотреть");
            string checkTranslate = Console.ReadLine();
            bool check = _dictionary.ContainsKey(checkTranslate);
            if (check)
            {
                foreach (var dic in _dictionary)
                {
                    if (dic.Key == checkTranslate)
                    {
                        Console.WriteLine($"Перевод слова {checkTranslate} - {dic.Value}");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Такого слова нет");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Словарь пуст");
            Console.WriteLine();
        }
    }
    public void DeleteDictionary()
    {
        if (_dictionary.Count != 0)
        {
            Console.WriteLine("Какое слово из словаря вы хотите удалить");
            Console.WriteLine();
            string delete = Console.ReadLine();
            bool check = _dictionary.ContainsKey(delete);
            if (check)
            {
                    _dictionary.Remove(delete);
                    Console.WriteLine();
                    Console.WriteLine("Слово успешно удалено");
                    Console.WriteLine();
                    return;            
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Такого слова нет");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Словарь пуст");
            Console.WriteLine();
        }
    }
    public void ChangeKey()
    {
        if (_dictionary.Count != 0)
        {
            Console.WriteLine("У какого слова вы хотите изменить перевод");
            string select = Console.ReadLine();
            var check = _dictionary.ContainsKey(select);
            if (check)
            {
                foreach (var dic in _dictionary)
                {
                    if (dic.Key == select)
                    {
                        Console.WriteLine("Введите перевод");
                        string translate = Console.ReadLine();
                        _dictionary[dic.Key] = translate;
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Такого слова нет");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Словарь пуст");
            Console.WriteLine();
        }
    }
    public void AddTranslate()
    {
        Console.WriteLine("Введите слово, к которому вы хотите добавить перевод");
        string select = Console.ReadLine();
        bool check = _dictionary.ContainsKey(select);
        if (check)
        {
            foreach (var dic in _dictionary)
            {
                if (dic.Key == select)
                {
                    Console.WriteLine("Введите перевод к этому слову");
                    string translate = Console.ReadLine();
                    _dictionary[dic.Key] = dic.Value + ',' +' ' + translate;
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Слова нет");
            Console.WriteLine();
        }
    }
    public void DeleteTranslate()
    {
        Console.WriteLine("Введите ключ слова, у которого вы хотите удалить перевод");
        string select = Console.ReadLine();
        bool check=_dictionary.ContainsKey(select);
        if (check)
        {
            foreach (var dic in _dictionary) 
            {
                if (dic.Key == select)
                {
                    Console.WriteLine("Введите перевод слова, который вы хотите удалить");
                    string deleteTranslate = Console.ReadLine();     // Как удалить отдельный перевод
                }
            }
        }
    }
}