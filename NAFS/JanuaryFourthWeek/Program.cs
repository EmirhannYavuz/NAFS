namespace NAFS.JanuaryFourthWeek;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hizmetlerimiz");
        Console.WriteLine("1. Birden ona kadar olan sayıları ekrana yazdırma servisi");
        Console.WriteLine("2. Sıfırdan girilen sayıya kadar olan sayıların toplamını ekrana yazdırma servisi");
        
        Console.WriteLine("Kullanmak istediğiniz servisi seçiniz: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                break;
            case 2:
                Console.WriteLine("Hangi sayıya kadar olan sayıların toplamını görmek istiyorsunuz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                
                for (int i = 0; i <= number; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                break;
            default:
                break;
        }
    }
}