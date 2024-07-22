
//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.(While)

Console.WriteLine("Limit Değerini Giriniz");

int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

while(sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

//Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız. (Do-while)

Console.WriteLine("Limit Değerini Giriniz");

int limit = Convert.ToInt32(Console.ReadLine());
int sayac = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}  while(sayac <= limit);

// Bu 2 kod arasındaki fark, 'while' dögüsünün koşulu kontrol edildikten sonra döngüyü çalıştırması ve potansiyel olarak hiçbir zaman çalışmamasıdır(eğer başlangıç koşulu sağlanmıyorsa).
//do-while döngüsü ise döngüyü en az bir kezz çalıştıracak şekilde tasarlandı.Çünkü koşul döngü içinde kontrol edilir.