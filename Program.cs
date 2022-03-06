using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //Farklı veri tiplerini array list içerisinde saklayabilirsiniz. Ve eleman ekleyerek ve cıkararak boyutunu dinamik olarak değiştirebilirsiniz.


            // array listler bir koleksion tipidir
            // bir den fazla veri tipni içinde barındırabilir
            //System.Collection.namespace altında bulunuyor

            ArrayList liste = new ArrayList();
            // nasıl eleman ekleriz
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // içerisindeki verilerfe erişim nasıl oluyor 
            Console.WriteLine(liste[1]);
            foreach(var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("******* Ad Range*****");
            string[] renkler = {"Kırmızı","sarı","yesil"};
            //birde generic list yapalım,int tipinde sayılar tutsun ataması
            List<int> sayılar  = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler); // collection tipindeki herseyi ekleyebiliyormusum 
            liste.AddRange(renkler);

            foreach(var item in liste)
                Console.WriteLine(item);

            //sort(sıralama) yapalım
            Console.WriteLine("**** SOrt*****");
            liste.Sort();// strin ve int deger kullanımların genelde patlar 

             foreach(var item in liste)
                Console.WriteLine(item);
            
            //Binary  search KENDİ İCİNDE SIRALAMAMIZ GEREKİYORMUS 
            Console.WriteLine("***** Binary Search *****");
            liste.BinarySearch(9);


            // Reverse 
            Console.WriteLine("**** Reverse ******");
            liste.Reverse();
            foreach( var item in liste)
                Console.WriteLine(item);

            // Clear 
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
            {
                
            }

        }
    }
}
