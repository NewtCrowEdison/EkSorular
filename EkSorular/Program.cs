namespace EkSorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru 1
            //Kullanıcıdan alınan iki sayı ve bir operatöre göre işlem yapacak bir hesap makinesi programı yazın (+, -, *, /).

            Console.WriteLine("Hesap Makinesi Programı");
            Console.WriteLine("1-) Toplama işlemi");
            Console.WriteLine("2-) Çıkarma işlemi");
            Console.WriteLine("3-) Çarpma işlemi");
            Console.WriteLine("4-) Bölme işlemi");
            Console.WriteLine("5-) Çıkış");
            //Bu soruyu restoran sorusu gibi switch case ile yapmaya karar verdim.
            //Yukarda basit bi menü oluşturduktan sonra kullanıcıdan yapmak istediği hesap işleminin sayısını girmesini istiyorum.
            //Bu while ile sınırsız döngüyü oluşturuyorum. Kullanıcı eğer 1den küçük veya 5ten büyük bir değer girerse başka bir değer girmesini isteyecek.
            while (true)
            {
                Console.WriteLine("İşlem yapmak istediğiniz sayıyı yazınız.");
                int hesapIslemi = int.Parse(Console.ReadLine());
                while (hesapIslemi < 1 || hesapIslemi > 5)
                {
                    Console.WriteLine("Geçersiz giriş yaptınız, lütfen 1 ile 5 arasında bir sayı giriniz");
                    hesapIslemi = int.Parse(Console.ReadLine());
                }
                //hesap makinesinden çıkışı switch case'te değilde burda tutmaya karar verdim çünkü burda if ile tutup aşağıda else ile switch case i tutmak daha mantıklı geldi
                if (hesapIslemi == 5)
                {
                    Console.WriteLine("Rojbin'in hesaplama makinesini kullandığınız için teşekkür ederiz. Taklitlerimizden sakının");
                    break;
                }
                //Kullanıcıdan işlem yapmasını istediği iki sayıyı burdada tutabilirdim ama switch case'in içerisinde her bir işlem için tutmak daha güzel görünür gibi geldi.
                //Ama bu şekilde gereksiz bir şekilde veri tutuluşu oluyor, o yüzden mantıklı bir çözüm değil bu yapılan.
                //Eğer kullanıcı değer girmez veya 0'a bölme işlemi yaparsa program'dan hata verip atıcak.
                switch (hesapIslemi)
                {
                    case 1:
                        Console.WriteLine("Toplama işlemini seçtiniz.\nBirinci sayıyı giriniz");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz");
                        double b = double.Parse(Console.ReadLine());
                        double toplam = a + b;
                        Console.WriteLine("Toplama işlemi sonucunuz : " + toplam);
                        break;
                    case 2:
                        Console.WriteLine("Çıkarma işlemini seçtiniz.\nBirinci sayıyı giriniz");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz");
                        double d = double.Parse(Console.ReadLine());
                        double cikarma = c - d;
                        Console.WriteLine("Çıkarma işlemi sonucunuz : " + cikarma);
                        break;
                    case 3:
                        Console.WriteLine("Çarpma işlemini seçtiniz.\nBirinci sayıyı giriniz");
                        double e = double.Parse(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz");
                        double f = double.Parse(Console.ReadLine());
                        double carpma = e * f;
                        Console.WriteLine("Çarpma işlemi sonucunuz : " + carpma);
                        break;
                    case 4:
                        Console.WriteLine("Bölme işlemini seçtiniz.\nBirinci sayıyı giriniz");
                        double g = double.Parse(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz");
                        double h = double.Parse(Console.ReadLine());
                        double bolme = g / h;
                        Console.WriteLine("Bölme işlemi sonucunuz : " + bolme);
                        break;
                }
            }
            #endregion

            #region Soru 2
            //Kullanıcıdan alınan bir alışveriş miktarına göre indirim tutarını hesaplayan bir program yazın
            //(100 TL üzeri alışverişlerde % 10 indirim, 50 - 100 TL arası % 5 indirim).

            //İlk olarak alışveriş tutarlarını tanımladım decimal olarak. burda decimal tanımlarken değerin yanına 'm' yazılmazsa eğer
            //C# bunu otomatik olarak double olduğunu varsayıyor ve type hatası veriyor.
            decimal buyukIndirim = 0.90m;
            decimal kucukIndirim = 0.95m;
            Console.WriteLine("Yaptığınız alışveris tutarını giriniz :");
            decimal alisverisTutari = decimal.Parse(Console.ReadLine());
            //Burada yine while ile döngüyü oluşturdum. alışveris miktarı 0'dan az olamaz eğer öyleyse hata vericek ve yeniden bir değer girmesini isteyecek kullanıcıdan.
            while (alisverisTutari <= 0)
            {
                Console.WriteLine("Yanlış bir miktar girdiniz");
                Console.WriteLine("Yaptığınız alışveris tutarını giriniz :");
                alisverisTutari = decimal.Parse(Console.ReadLine());
            }
            if (alisverisTutari >= 100)
            {
                decimal yeniAlisverisTutari = alisverisTutari * buyukIndirim;
                Console.WriteLine($"İndirimden sonraki alışveriş tutarınız : {yeniAlisverisTutari}");
            }
            else if (alisverisTutari >= 50)
            {
                decimal yeniAlisverisTutari = alisverisTutari * kucukIndirim;
                Console.WriteLine($"İndirimden sonraki alışveriş tutarınız : {yeniAlisverisTutari}");
            }
            else
            {
                Console.WriteLine($"İndirim için yeterli alışveriş yapmadınız. Daha fazla şey satın alın. Yaşasın kapitalizm.\nCONSUME OBEY DIE");
            }
            #endregion
        }
    }
}
