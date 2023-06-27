Console.Clear();
//-постановка задачи
void TZ()
{
    Console.WriteLine("Написать программу, \n" +
                "!1! - которая из имеющегося массива строк\n" +
                "!2! - формирует новый массив из строк, \n" +
                "!3! - длина которых меньше, либо равна 3 символам.\n" +
                "!4-!выбор! - Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.\n" +
                "!5-ограничение!- При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");
}
TZ();

//-!2! - формирует новый массив из строк
string[] FillStringArray(string message)
{
    string[] result = new string[0]; int size = 0;
        try
        {
            Console.WriteLine(message);
                string some_str = "";string user_input ="";
                while(user_input.ToLower() != "stop")
                {
                    size++;
                    Console.Write($"!ЧТОБЫ ПРЕКРАТИТЬ ВВЕДИ stop!введите зачение № {size}: ");
                    user_input = Console.ReadLine()!;
                    if(user_input.ToLower() != "stop") some_str = some_str + user_input+"|";
                }
            Array.Resize(ref result,result.Length+size);
            result = some_str.Split("|");
        }
        catch{FillStringArray("\nошибка метода Prompt,попробуйте ввести данные снова: ");}
    return result;
}
string[] string_array = FillStringArray("прошу ввести с клавиатуры данные для первоначального массива: ");

                                    //-вывести на экран массив
                                    PritStringArray(string_array);
                                    void PritStringArray(string[] array)
                                    {
                                        foreach(var el in array){Console.Write($"{el}\t");}
                                    }
//-!3! - длина которых меньше, либо равна 3 символам
LeftThreeCharOfArray(string_array);
void LeftThreeCharOfArray(string[] array)
{
    Console.Write("\n\nДанные, длина которых меньше, либо равна 3 символам: ");
    foreach(var el in array)
    {
        if(el.Length<=3) Console.Write($"{el}\t");
    }
}