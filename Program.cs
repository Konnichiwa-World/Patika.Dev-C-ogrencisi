using System;

namespace consol_programlama
{

    class consol_programlama
{
        static void Main(string[] args)
{
    Console.WriteLine("Lutfen TC kimlik numaranizin ilk 9 basamagini yaziniz:");

string m = Console.ReadLine();

 string a = m.Substring(1,1); //Bu blokta amaç; string olarak girilen Tc no.yu basamaklarına ayırmak.
 string b = m.Substring(2,1); 
 string c = m.Substring(3,1); 
 string d = m.Substring(4,1); 
string e = m.Substring(5,1); 
string f = m.Substring(6,1); 
string g = m.Substring(7,1); 
string h = m.Substring(8,1); 
string i = m.Substring(m.Length - 1); 

int aa = Convert.ToInt16(a); //işte hatalı blok burası. 1. basamağı inte çevireceğine 2. basamağı alıyor!!!
int bb = Convert.ToInt16(b); //2. basamağı alacağına 3. basamağı alıyor!
int cc = Convert.ToInt16(c); //3. basamağı alacağına 4. basamağı alıyor!
int dd = Convert.ToInt16(d); // bu şekilde bir hata zincirlemesi var.
int ee = Convert.ToInt16(e); 
int ff = Convert.ToInt16(f); 
int gg = Convert.ToInt16(g); 
int hh = Convert.ToInt16(h); 
int ii = Convert.ToInt16(i); 

 int t = (aa + cc + ee + gg + ii)*7 ; //TC no algoritmasına göre, 1. 3. 5. 7. ve 9. basamaklar toplanıp 7 ile çarpılmalı.
 int s = bb + dd + ff + hh; // 2. 4. 6. 8. basamaklar toplanmalı.
 int j1 = (t-s)%10;   //sonra bu 2 işlemin farkının kalanı, bize TC no.nun 10. basamağını verir.

 int k = aa + bb + cc + dd + ee + ff + gg + hh + ii + j1; //ilk 10 basamak artık elimizde, hepsini topluyoruz.  
int k1 = k%10; //aynı şekilde kalan bize 11. basamağı veriyor.

 string l= Convert.ToString(m + j1 + k1); //TC kimlik no. elimizde.
 Console.WriteLine("TC kimlik numaraniz:" + l);
}}}
