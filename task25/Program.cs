// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Возвести число в квадрат — значит умножить его само на себя. 
// Возвести число в куб — значит умножить его само на себя три раза. 
// Возвести число в натуральную степень — значит умножить его само на себя раз: Степень с целым показателем. 
// Показатель степени может быть не только натуральным (то есть целым положительным), но и равным нулю, а также целым отрицательным.


// Решение готово, помощь с интернета!!!

Console.Clear();
Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int st = A;

for (int i = 1; i < B; i++) 
{
st = st * A; 
}
Console.WriteLine("A в степени B равно: " + st); 

// 20 строка (Стас, прочитать, понять не могу вот эту надпись, вот как... i-индекс он 1 так как у нас целое число, так? i-< B тоесть пока индекс будет меньше B то что?? и i++ это понятно, переберает, типа счетчик) Или как, обьясни как ты читаешь это?
// 22 строка (Стас, тут получается говорим что моя степень, она равна степени умноженное на число А, как понять... может на цифрах будет понятнее, подскажи..)
// 24 строка (тут пишем что текст будет отражаться и + моя степень, тесть ответ моей степени?)


