// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите цифру 1 для рассчета расстояния между точками в 3D или цифру 2 для рассчета в 2D");
int choice = int.Parse (Console.ReadLine());

if (choice == 1)
{
Console.WriteLine("Введите у первого числа координаты по оси Х");
int X1 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у первого числа координаты по оси У");
int Y1 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у первого числа координаты по оси Z");
int Z1 = int.Parse (Console.ReadLine());


Console.WriteLine("Введите у второго числа координаты по оси Х");
int X2 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у второго числа координаты по оси У");
int Y2 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у второго числа координаты по оси Z");
int Z2 = int.Parse (Console.ReadLine());


int deltaX = X1 - X2;

int deltaY = Y1 - Y2;

int deltaZ = Z1 - Z2;

int deltaE = (deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);

double delta3D;

delta3D = Math.Pow(deltaE, 0.5);



Console.WriteLine($"Расстояние между одной и второй точкой в 3D равна {delta3D}");
}



else
{
    
Console.WriteLine("Введите у первого числа координаты по оси Х");
int X1 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у первого числа координаты по оси У");
int Y1 = int.Parse (Console.ReadLine());


Console.WriteLine("Введите у второго числа координаты по оси Х");
int X2 = int.Parse (Console.ReadLine());

Console.WriteLine("Введите у второго числа координаты по оси У");
int Y2 = int.Parse (Console.ReadLine());




int deltaX = X1 - X2;

int deltaY = Y1 - Y2;



int deltaE = (deltaX*deltaX + deltaY*deltaY );

double delta3D;

delta3D = Math.Pow(deltaE, 0.5);



Console.WriteLine($"Расстояние между одной и второй точкой в 3D равна {delta3D}");


}