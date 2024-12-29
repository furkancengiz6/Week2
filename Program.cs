using System.Diagnostics.Metrics;

//Hafta 2 - Kapanış

/*
1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?
*/

Console.WriteLine("Merhaba \nNasılsın ? \nIyiyim \nSen Nasılsın ?");

Console.WriteLine("-------------------------------------------------------------------------------------------------");

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

int number1 = 10;
string text1 = "Hello World";
Console.WriteLine($"Metinsel Ifade : {text1} \nTamsayisal ifade : {number1}");
Console.WriteLine("-------------------------------------------------------------------------------------------------");

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();
int number2 = rnd.Next(1, 100);
Console.WriteLine($"Rastgele uretilen sayi : {number2}");
Console.WriteLine("-------------------------------------------------------------------------------------------------");

//4.Soru
Random rnd1 = new Random();
int number3 = rnd1.Next(1, 100);
double mod = number3 % 3;
Console.WriteLine($"Rastgele uretilen sayi : {number3} 3 e bölümünden kalan  : {mod}");

Console.WriteLine("-------------------------------------------------------------------------------------------------");

//5.Soru

Console.WriteLine("Lutfen yasınızı giriniz : ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Console.WriteLine("-------------------------------------------------------------------------------------------------");

//6.Soru

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("-------------------------------------------------------------------------------------------------");


//7.Soru  : Bu soruyu doğru anladım mı emin değilim ?

Console.WriteLine("Ilk Metini giniriniz :");

string text2 = Console.ReadLine();

Console.WriteLine("Ikinci Metini giriniz :");

string text3 = Console.ReadLine();


text2 = "Gülse Birsel ";
text3 = "Demet Evgar ";

Console.WriteLine($"Ilk Metin : {text2} \nIkinci Metin : {text3}");

Console.WriteLine("-------------------------------------------------------------------------------------------------");

//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();


Console.WriteLine("-------------------------------------------------------------------------------------------------");

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

static int Sum(int a , int b)
{
    return a + b;
}

Console.WriteLine(Sum(5, 10));

Console.WriteLine("-------------------------------------------------------------------------------------------------");

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.


string result = TrueOrFalse();
Console.WriteLine($"Donen deger{ result}");

static string TrueOrFalse()
{
    Console.WriteLine("Lutfen true or false giriniz : ");

    string trueOrFalse = Console.ReadLine();



    if (bool.TryParse(trueOrFalse, out bool result ))
    {
        return result ? "Doğru bir giriş yaptınız: True" : "Doğru bir giriş yaptınız: False";
    }
    else
    {
        return "Geçersiz bir değer girdiniz. Lütfen true ya da false yazınız.";
    }

}


Console.WriteLine("-------------------------------------------------------------------------------------------------");

//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.


int age1 = 20;
int age2 = 30;

int age3 = 40;

Console.WriteLine($"En yaşlı kişi : {Oldest(age1, age2, age3)}");

static int Oldest(int firstAge , int secondAge , int thirdAge)
{

    return Math.Max(firstAge, Math.Max(secondAge, thirdAge));

}


//params ile :

int age4 = 20;
int age5 = 30;
int age6 = 40;
int age7 = 50;

Console.WriteLine($"En yaşlı kişi : {OldestParams(age4, age5, age6, age7)}");

static int OldestParams(params int[] ages)
{
    int maxAge = ages[0];//ilk elemanı alıyoruz

    foreach (var age in ages)
    {
        if (age > maxAge)
        {
            maxAge = age;
        }
 
    }

    return maxAge;
}




Console.WriteLine("-------------------------------------------------------------------------------------------------");


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.



int[] numbers = new int[1]; // Başlangıcta tek elemanlı 
        int count = 0; // Girilen sayıları takip eder

        Console.WriteLine("Lutfen bir tam sayı giriniz (cıkmak için 'cıkıs' yazın):");

        while (true)
        {
            string input = Console.ReadLine(); // Kullanıcıdan giris al

            if (input.ToLower() == "cıkıs") // Cıkıs yapabilmesi icin
            {
                break;
            }

            if (int.TryParse(input, out int number)) // Girilen değer bir tam sayı mı kontrol et
            {
                if (count == numbers.Length) // Dizi doluysa
                {
                    int[] tempArray = new int[numbers.Length * 2]; // Dizi boyutunu artır
                    for (int i = 0; i < numbers.Length; i++) // Elemanları yeni diziye aktar
                    {
                        tempArray[i] = numbers[i];
                    }
                    numbers = tempArray; // Yeni diziyi eski diziye ata
                }

                numbers[count] = number; // Sayıyı diziye ekle
                count++; // Sayı sayacını artır
            }
            else
            {
                Console.WriteLine("Geçerli bir tam sayı giriniz."); // Hatalı giris uyarısı
            }
        }

        Console.WriteLine("Girilen sayılar:");
        foreach (var num in numbers) // tum elemanları dolasmamız gerekyor
        {
            if (num != 0) // Varsayılan 0 değerleri yazdırılmaz
            {
                Console.WriteLine(num);
            }
        }

        Console.WriteLine("Programdan çıkıldı.");



Console.WriteLine("-------------------------------------------------------------------------------------------------");

//13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("Lutfen 2 Isim giriniz  : ");
String firstName = Console.ReadLine();
String secondName = Console.ReadLine();

Console.WriteLine($"Girilen isimler : 1.{firstName} ve 2.{secondName}");

Console.WriteLine(ChangeName(firstName,secondName));
static string ChangeName(string firstName, string secondName)
{
    string temp = firstName;
    firstName = secondName;
    secondName = temp;
    return $"Değiştirilen isimler : 1.{firstName} ve 2.{secondName}";
}

Console.WriteLine("-------------------------------------------------------------------------------------------------");

//Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

Console.WriteLine("Lutfen bir sayi giriniz : ");
int number7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{IsEven(number7)} ");

static bool IsEven(int number)
{
    return number % 2 == 0;

}



Console.WriteLine("-------------------------------------------------------------------------------------------------");

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Lutfen hızı giriniz : ");
int speed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lutfen zamanı giriniz : ");
int time = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Gidilen yol : {CalculateDistance(speed, time)} km");

static int CalculateDistance(int speed, int time)
{
    return speed * time;
}


Console.WriteLine("-------------------------------------------------------------------------------------------------");

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.WriteLine("Lutfen yarıçapı giriniz : ");
double r = Convert.ToDouble(Console.ReadLine());

double area = AreaOfCircle(r);
Console.WriteLine($"Dairenin alanı : {area}");

static double AreaOfCircle(double r)
{
    return Math.PI * r * r;
}



Console.WriteLine("-------------------------------------------------------------------------------------------------");

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.


string text = "Zaman bir GeRi SayIm";
text = text.ToUpper();
Console.WriteLine(text);
text = text.ToLower();
Console.WriteLine(text);




Console.WriteLine("-------------------------------------------------------------------------------------------------");

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string text5 = "    Selamlar   ";
text = text5.Trim();
Console.WriteLine(text5);

