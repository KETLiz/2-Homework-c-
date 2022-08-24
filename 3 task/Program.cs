// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());

void Holiday()
{
    if (x == 6 || x == 7)
    {
        Console.WriteLine("Выходной! Ура!");
    }
    else
    {
        Console.WriteLine("Иди на работу, лентяй!");
    }
    
}
Holiday();
