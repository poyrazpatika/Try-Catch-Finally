using System;

namespace Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            //try // Hataya neden olabilecek kod bu bloğa yazılır.
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
            //}
            //catch (Exception ex) // Hata oluşursa hatanın yakalanacağı kod bloğu.
            //{
            //    Console.WriteLine("Hata:" + ex.Message.ToString());
            //}
            //finally // Hata oluşsun ya da oluşmasın, bu kod bloğu çalışır.
            //{
            //    Console.WriteLine("İşlem Tamamlandı.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı.");
            }
        }
    }
}
