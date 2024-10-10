// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Duzbucaqli z  = new Duzbucaqli(2,5);
z.a = 2; z.b = 6;
//Console.WriteLine("sahe:"+z.sahe());
//Console.WriteLine("perimetr:"+z.perimetr());

Noqte t = new Noqte();
double r = 3;
t.x=2; t.y=3;
bool k = t.chevre(r);
//if (k) Console.WriteLine("icindedir");
//else Console.WriteLine("icinde deyil");
Masin m = new Masin(4);

//Console.WriteLine("kordinati " + m.hereket(9));
const int n = 5;
int[] a = new int[n];
Random random = new Random();

//Console.WriteLine(random.Next(5, 15));
for (int i = 0; i < n; i++)
{
    //massivi doldurmaq
    a[i] = random.Next(5,15);
}
//massivin ilkin ardicilligini capa verdik
for (int i = 0; i < n; i++)
{
    //Console.Write(a[i] + " ");

}
//Console.WriteLine();
int c;
//massivi reverse ettik
for (int i = 0; i < n/2; i++)
{
    c = a[i];
    a[i] = a[n - 1 - i];
    a[n - 1 - i] = c;


}
//massivin reversinin capa verilmesi

for (int i=0; i < n; i++)
{
    //Console.Write(a[i]+" ");

}

/// <summary>
/// telebe
/// </summary>
int say = 4;
int[] l = new int[say];
Telebe t1 = new Telebe();

for (int i = 0; i < say; i++)
{
    //massivi doldurmaq
    l[i] = i;
}
t1.set(l,say);
//for (int i = 0; i < say; i++)
//    Console.WriteLine(t1.bal[i]);

//cevrenin sahesi-------------------------------------3

Chevre cevre = new Chevre(2);
Console.WriteLine("saheCevre:"+cevre.sahe());
Console.WriteLine("perimetrCevre:"+cevre.perimetr());

//sual 7 ------------------------------------
Telebe7 telebe7 = new Telebe7();
Console.WriteLine("melumat:" + telebe7.melumat());


//===============================================
int aca = 3000;
Kitab k1 = new Kitab();
Kitab k2 = new Kitab();
Kitab k3 = new Kitab();
k1.il = 2000;
k2.il = 2020;
k3.il = 2010;
k1.kitabinAdi = "salam";
k2.kitabinAdi = "salam1";
k3.kitabinAdi = "salam2";
Kitab[] f = [k1,k2,k3 ];

for (int i = 0; i < 3; i++)
{
    if (f[i].il < aca)
    {
        Console.WriteLine(f[i].melumat());   
    }

}




//sual 7---------------------------------------------------

public class Telebe
{
    int n;
    public int [] bal;
    public void set(int[] a, int n1)
    {
        this.n = n1;
        bal = new int[n];
        this.bal =a;
    }
    
}

//-------------------------------------------------------------------

//sual 2-----------------------------------------------------------
public class Masin
{
    public double x;
    public Masin(double a)
    {
        this.x = a;
    }
    public double hereket(double dx)
    {
        return x + dx;
    }


}

//----------------------------------------------------------------




//sual 5-6--------------------========================-------------
public class Duzbucaqli
{
    public double a, b;
    public Duzbucaqli(double x, double y) { this.a = x; this.b = y; }
    public double perimetr()
    { return 2 * (a + b); }
    public double sahe()
    { return a * b; }
}
//-----------------------------------------------
public class Noqte
{
    public double x,y;
    public bool chevre(double r)
    { if (x * x + y * y < r * r) return true;
        else return false;
    }

}


//sual 3 -4 -------------------------------------------------
public class Chevre
{
    public double radius;
    public Chevre(double x) { this.radius = x; }
    public double sahe()
    { return 3.14 * radius * radius; }
    public double perimetr()
    { return 3.14 * 2 * radius; }

}

//---------------------------------------------------------


//sual 7 --------------------------------------------------------
public class Telebe7
{
    string ad = "Fatime";
    string soyad = "Memmedli";
    string yas = "20";
    public string melumat()
    { return ad+"\t"+soyad + "\t" + yas; }
}

//sual 8 ---------------===============================
public class Kitab
{
    public string kitabinAdi;
    public int il;
    public string melumat()
    { return kitabinAdi; }



}
