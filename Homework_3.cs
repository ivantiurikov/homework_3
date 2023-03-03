// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// bool Check(int num)
// {
//     int dig1 = num / 10000;
//     int dig2 = num % 10000 / 1000;
//     int dig3 = num % 100 / 10;
//     int dig4 = num % 10;
//     if(dig1 == dig4 && dig2 == dig3)
//     {
//         return true;
//     }
//     return false;
// }
// Console.WriteLine("Input 5-digit number:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Check(number));



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
// }
// Console.WriteLine("Input coordinate X of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of A point: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of B point: ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// double distance = FindDistance(x1, y1, x2, y2, z1, z2);
// Console.WriteLine($"Distance between A and B is {distance}");



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Power(double N)
// {
//     double i = 1;
//     while(i <= N)
//     {
//         Console.WriteLine($"{i} -> {i}^3 -> {Math.Pow(i, 3)}");
//         i++;

//     }
// }
// Console.WriteLine("Input the number N:");
// double N = Convert.ToDouble(Console.ReadLine());
// Power(N);