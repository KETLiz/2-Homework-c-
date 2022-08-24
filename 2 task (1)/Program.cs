// See https://aka.ms/new-console-template for more information
void Number()
{
    Console.Write("Введите число: ");
    int anyNumber = Convert.ToInt32(Console.ReadLine());
    string anyNumberText = Convert.ToString(anyNumber);
    if (anyNumberText.Length > 2){
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
    }
    else {
    Console.WriteLine("-> третьей цифры нет");
    }
}
Number();