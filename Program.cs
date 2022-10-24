// See https://aka.ms/new-console-template for more information
using System;

namespace recursive // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result=1;
            for(int i=1;i<5;i++)
            result=result*3;
            Console.WriteLine(result);

            islemler instance=new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension metotlar
            string ifade="Fatih TALAS";
            bool sonuc=ifade.checkspaces();
            Console.WriteLine(sonuc);

            if(sonuc)
            Console.WriteLine(ifade.removewhitespaces());
            Console.WriteLine(ifade.makeuppercase());
            Console.WriteLine(ifade.makelowercase());

            int [] dizi={9,3,6,2,1,5,0};
            dizi.sortarray();
            dizi.ekranayaz();

            int sayi=5;
            Console.WriteLine(sayi.isevennumber());

            Console.WriteLine(ifade.getfirstchar());

        }
        
    }
    public class islemler
        {
            public int Expo(int sayi,int us)
            {
                if(us<2)
                return sayi;
                return Expo(sayi,us-1)*sayi;
            }
        }
    public static class Extension
        {
            public static bool checkspaces(this string param)
            {
                return param.Contains(" ");
            }
            public static string removewhitespaces(this string param)
            {
                string [] dizi=param.Split(" ");
                return string.Join("",dizi);
            }
            public static string makeuppercase(this string param)
            {
                return param.ToUpper();
            }
            public static string makelowercase(this string param)
            {
                return param.ToLower();
            }
            public static int[] sortarray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }
            public static void ekranayaz(this int[] param)
            {
                foreach (var sayi in param)
                Console.WriteLine(sayi);
            }
            public static bool isevennumber(this int param)
            {
                return param%2==0;
            }
            public static string getfirstchar(this string param)
            {
                return param.Substring(0,1);
            }
        }
}
