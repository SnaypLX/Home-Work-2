// Задать номер четверти, показать диапазоны для возможных координат


Console.WriteLine("Введите номер четверти");

int numbers = int.Parse (Console.ReadLine());


if (numbers < 1 || numbers > 4)
{
    Console.WriteLine("Вы не ввели правильный номер четверти(Введите от 1 до 4)");
}

else if (numbers == 1)
{
    Console.WriteLine("Возможные координаты в 1 четверти: Х > 0, Y > 0");
}
else if (numbers == 2)
{
    Console.WriteLine("Возможные координаты в 2 четверти: Х < 0, Y > 0");
}

else if (numbers == 3)
{
    Console.WriteLine("Возможные координаты в 3 четверти: Х < 0, Y < 0");
}

else if (numbers == 4)
{
    Console.WriteLine("Возможные координаты в 4 четверти: Х > 0, Y < 0");
}


