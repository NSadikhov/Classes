using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var mlm = new Muellim("Samir","Kerimov");
            var liste = new List<Student>();
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + ".Telebenin adi: ");
                var ad = Console.ReadLine();
                string adilkharf = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ad);
                Console.Write(i + ".Telebenin soyadi: ");
                var soyad = Console.ReadLine();
                string soyadilkharf = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(soyad);
                var tlb = new Student(adilkharf, soyadilkharf);         
                liste.Add(tlb);               
            }
            mlm.Goster(liste);
            Console.ReadLine();
        }
    }
    class Muellim
    {
        public string Name;
        public string Surname;
        public Muellim(string nm,string srnm)
        {
            Name = nm;
            Surname = srnm;
        }

        public void Goster(List<Student> sagirdler)
        {
            var sayi = 0;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(Surname+" "+Name+"-in sinfinin siyahisi:");       
            foreach (var tkr in sagirdler)
            {
                sayi++;
                Console.WriteLine(sayi+"-"+tkr.Name+" "+tkr.Surname);
            }    
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public Student(string nm, string srnm)
        {                 
            Name = nm;
            Surname = srnm;
        } 
    }
}
