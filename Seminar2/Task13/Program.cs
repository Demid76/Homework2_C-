﻿Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
    Console.WriteLine("Третья цифра числа = " + NumberText[2]);
}
else {
    Console.WriteLine("Третьей цифры в числе нет");
}
