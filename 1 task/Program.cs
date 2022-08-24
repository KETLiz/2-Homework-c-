// See https://aka.ms/new-console-template for more information
void PrintNumber ()
{
    Console.WriteLine("Введите трехзначное число: ");
    int x = Convert.ToInt32(Console.ReadLine());

    int a = x % 100;
    int b = a / 10;
    Console.WriteLine($"Второе число из трехзначного числа равно {b}");
}
PrintNumber();