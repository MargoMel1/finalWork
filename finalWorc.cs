void finalWork()
{
    Console.WriteLine("***Итоговая проверочная работа***");
    Console.WriteLine("Программа формирования из имеющегося массива строк нового массива");
    Console.WriteLine("с элементами, длина которых меньше или равна 3 символам");
    string[] elements = new string[] { "hello", "2", "World", ":-)" };

    Console.WriteLine(" ");
    Console.Write("Заданный массив: ");
    Console.Write($"{elements[0]}, {elements[1]}, {elements[2]}, {elements[3]}");
    Console.WriteLine(" ");
    
    Console.Write("Искомый массив: ");
    for (int i = 0; i < elements.Length; i++)
    {

        if (elements[i].Length <= 3)
        {
            Console.Write($"{elements[i]}, ");
        }

    }
    Console.WriteLine(" ");
}

finalWork();