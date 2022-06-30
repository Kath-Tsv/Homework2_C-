//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
isolation (number);

void isolation (int currentNumber)
{
 if (currentNumber / 100 > 0)
 {
    string crutch = Convert.ToString (currentNumber);
    char result = crutch[2];
    Console.WriteLine(result);
 }
 else 
 {
    Console.WriteLine("Третьей цифры нет.");
 }
}