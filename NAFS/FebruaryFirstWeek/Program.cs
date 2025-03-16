namespace NAFS.FebruaryFirstWeek;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hizmetlerimiz");
        Console.WriteLine("1. 5 elemanlı bir dizi oluşturma servisi");
        Console.WriteLine("2. Bir dizideki en büyük sayıyı bulma servisi");
        
        Console.WriteLine("Kullanmak istediğiniz servisi seçiniz: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                int[] numbers = new int[5];
        
                Console.WriteLine("Lütfen 5 adet sayıyı sırayla girin:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Sayı {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
        
                Console.WriteLine("Girilen sayılar:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Girdiğiniz {i + 1}. sayı: {numbers[i]}");
                }
                break;
            case 2:
                Console.Write("Dizinin eleman sayısını girin: ");
                int n = int.Parse(Console.ReadLine());
                
                int[] numbers2 = new int[n];

                Console.WriteLine($"{n} sayıyı girin:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Sayı {i + 1}: ");
                    numbers2[i] = int.Parse(Console.ReadLine());
                }
                
                int max = numbers2[0];

                for (int i = 1; i < n; i++)
                {
                    if (numbers2[i] > max)
                    {
                        max = numbers2[i];
                    }
                }
                
                Console.WriteLine($"Dizinin en büyük sayısı: {max}");
                break;
        }
    }
}