//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
Day (number);

void Day (int currentNumber)
{
    if (currentNumber==6 || currentNumber ==7)
    {
        Console.WriteLine ("Это выходной! Чиллим!!!");
    }
    else if (currentNumber>0 && currentNumber <6)
    {
        Console.WriteLine ("Это будний день, работаем.");
    }
    else 
    {
        Console.WriteLine ("Такого дня недели ещё не придумали, попробуй снова.");
    }
}