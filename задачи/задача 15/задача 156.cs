



Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7) {
    Console.WriteLine("Вы ошиблись !! Введите число");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a==1) Console.WriteLine("Нет");
if (a==2) Console.WriteLine("Нет");
if (a==3) Console.WriteLine("Нет");
if (a==4) Console.WriteLine("Нет");
if (a==5) Console.WriteLine("Нет");
if (a==6) Console.WriteLine("ДА");
if (a==7) Console.WriteLine("ДА");   




