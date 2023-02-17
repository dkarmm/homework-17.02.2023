// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// range = sqrt((x2-x1)**2 + (y2-y1)**2 + (z2-z1)**2)

void addCoords(int[] array)
{
    int index = 0;
    int size = array.Length;
    int position = 1;
    while (index < size)
    {
        Console.Write("Введите " + position + " координату точки: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
        position++;
    }
}
void showCoords(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
double findRange(int[] arrayA, int[] arrayB)
{
    double rangeFirst = Math.Pow(arrayB[0] - arrayA[0], 2);
    double rangeSecond = Math.Pow(arrayB[1] - arrayA[1], 2);
    double rangeThird = Math.Pow(arrayB[2] - arrayA[2], 2);
    double result = Math.Sqrt(rangeFirst + rangeSecond + rangeThird);
    return result;
}
int[] dotA = new int[3];
int[] dotB = new int[3];
Console.WriteLine("Введите координаты для точки А.");
addCoords(dotA);
Console.Write("Точка А находится на координатах: ");
showCoords(dotA);
Console.WriteLine();
Console.WriteLine("Введите координаты для точки B.");
addCoords(dotB);
Console.Write("Точка B находится на координатах: ");
showCoords(dotB);
Console.WriteLine();
double result = findRange(dotA,dotB);
Console.Write("Координаты точек в пространстве: " + (Math.Round(result, 2)));
Console.WriteLine();