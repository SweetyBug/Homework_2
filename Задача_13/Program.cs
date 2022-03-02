int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());
int ost = numberFirst % numberSecond;
if (ost == 0)
{
    Console.WriteLine("Остаток: Кратно");
}
else
{
    Console.WriteLine("Остаток: " + ost);
}