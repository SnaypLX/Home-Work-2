// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


Console.WriteLine("Введите число обозначающее день недели");

int day = int.Parse(Console.ReadLine());

if (day < 6)
{
    Console.WriteLine("День недели - рабочий");
}
else
{
    Console.WriteLine("День недели - выходной");
}