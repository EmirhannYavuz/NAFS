namespace NAFS.JanuarySecondWeek;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("İkinci sayıyı giriniz: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("1. Sayı = " + firstNumber + " 2. Sayı = " + secondNumber);
    }
}