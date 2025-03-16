namespace NAFS.JanuaryThirdWeek;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hizmetlerimiz");
        Console.WriteLine("1. Girilen sayı tek mi çift mi kontrol etme servisi");
        Console.WriteLine("2. Girilen sayı pozitif mi negatif mi kontrol etme servisi");
        
        Console.WriteLine("Kullanmak istediğiniz servisi seçiniz: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
          case 1: 
              Console.WriteLine("Tek mi çift mi kontrol etmek istediğiniz sayıyı giriniz: ");
              int number1 = Convert.ToInt32(Console.ReadLine());

              if (number1 % 2 == 0)
              {
                  Console.WriteLine("Girdiğiniz sayı çift.");
              }
              else
              {
                  Console.WriteLine("Girdiğiniz sayı tek.");
              }
              break;
          case 2:
              Console.WriteLine("Pozitif mi negatif mi kontrol etmek istediğiniz sayıyı giriniz: ");
              int number2 = Convert.ToInt32(Console.ReadLine());

              if (number2 > 0)
              {
                  Console.WriteLine("Girdiğiniz sayı pozitif.");
              }
              else if (number2 < 0)
              {
                  Console.WriteLine("Girdiğiniz sayı negatif.");
              }
              else
              {
                  Console.WriteLine("Girdiğiniz sayı sıfır.");
              }
              break;
            default:
                break;
        }
    }
}