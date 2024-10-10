using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    internal class Fiqur
    {
        public double en; // public yazmasaq eger varisler gormeyesidi, protected edende ise miras hemin deyiseni gorsede diger qonsu sinifler gormeyecek(hemcinin yaranan obyektle cagirsaqda gormeyecek)
        public double uzunluq; // public yazmasaq eger varisler gormeyesidi
        public Fiqur() { en = 0; uzunluq = 0; }
        public Fiqur(double x, double y) 
        { en = x; uzunluq = y; }
        public Fiqur(double y)
        {uzunluq = y; }
        public double eni
        {
            get { return en; }
            set { en = value < 0 ? -value : value; }
        }
        
    }
    class Ucbucaq : Fiqur
    {
        string s;
        new double en;// valideyndekini yeniden teyin etmek ucun new olmalidir, ve eger asagida ucbucagda eni istifade elesen ucbucaqdakini gotrurur,eger valideyndekini isteyirikse base.en yazib cagirmaliyiq
        public Ucbucaq(double e, double u, string s1) : base(e, u) { string s = s1; }
        public Ucbucaq( double u, string s1) : base(u) 
        { string s = s1; }
        double sahe() { return en * uzunluq; }

    }
    class duzbucaqli
    {
        double sahe()
        {
            Fiqur x = new Fiqur();
            return x.en * x.uzunluq;
        }
        //    bool sade(int y)
        //    {
        //        for (int i = 2; i <= y / 2; i++)
        //        {
        //            if(y%i== 0)
        //                return false;
        //            return true;    
        //        }
        //    }
    }
}

//ref out params  ----