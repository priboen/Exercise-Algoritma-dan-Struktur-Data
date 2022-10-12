using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    //membuat class program
    class Program
    {
        //mendeklarasi array dengan nilai interger dan nama variable adri dengan maksimal data 25
        private int[] adri = new int[25];
        //mendeklarasi variable n dengan nilai interger
        private int n;

        //membuat method read
        public void read()
        {
            //membuat function perulangan dengan menggunakan while
            while (true)
            {
                //membuat input text
                Console.Write("Masukan banyaknya elemen pada array : ");
                //menerima hasil input text
                string s = Console.ReadLine();
                //mendeklarasikan variable n menjadi interger 32
                n = Int32.Parse(s);

                //membuat function if apabila nilai n kurang dari maksimal data
                if (n <= 25)
                    break;
                else
                    //membuat text untuk memberi tahu bahwa maks element adalah 25
                    Console.WriteLine("\n Array dapat mempunyai maksimal 25 element. \n");
            }

            //membuat text untuk input
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Masukan elemen pada array : ");
            Console.WriteLine("-----------------------------------");

            //membuat function for jika "i" memiliki nilai 0 dan jika i kurang dari "n" maka "i" akan bertambah
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                adri[i] = Int32.Parse(s1);
            }
        }

        //membuat method untuk mengurutkan array
        public void SortArray()
        {
            //membuat function perulangan untuk scanning
            for (int i = 0; i <= n - 2; i++)
            {
                //deklarasi variabel temp dan index
                int temp, index;
                //mendeklarasi bahwa nilai variabel index adalah "i"
                index = i;
                //membuat perulangan scanning
                //variable ma merupakan min_index dan md dari huruf pertama dan huruf akhir dalam nama saya
                for (int md = 1 + i; md <= n - 1; md++)
                {
                    //membuat function untuk membandingkan angka
                    if (adri[md] < adri[index])
                    {
                        //menyimpan angka terkecil dalam variable "ma"
                        index = md;
                    }
                }

                //mengurutkan angka dari yang kecil ke besar
                temp = adri[index];
                adri[index] = adri[i];
                adri[i] = temp;

            }


        }

        //membuat method output array yang telah diurutkan
        public void display()
        {
            //membuat text
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Element array yang telah tersusun : ");
            Console.WriteLine("-----------------------------------");

            //membuat method untuk menampilkan urutan array
            for (int MA = 0; MA < n ; MA++)
            {
                Console.WriteLine(adri[MA]);
            }
            Console.WriteLine("");

        }

        
        //membuat methoid main untuk menjalankan program
        static void Main(string[] args)
        {

            //mendeklarasikan class program menjadi "Exe"
            Program Exe = new Program();
            //memanggil method read
            Exe.read();
            //memanggil method sortArray
            Exe.SortArray();
            //memanggil method display
            Exe.display();

            //membuat text
            Console.WriteLine("\n Tekan apa saja untuk keluar.");
            //membuat program membaca hasil input user untuk keluar
            Console.Read();
        }
    }
}