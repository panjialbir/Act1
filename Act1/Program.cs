﻿using System;

namespace Bubble_Sort
{
    class Program
    { //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi atau method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
                Console.WriteLine("");
                Console.WriteLine("========================================");
                Console.WriteLine("Masukkan Elemen Array");
                Console.WriteLine("========================================");

                //pengguna memasukkan elemen pada array
                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    String s1 = Console.ReadLine();
                    a[i] = Int32.Parse(s1);
                }
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("================================");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                //pada past i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                    if (a[j] > a[j + 1]) //jika elemen tdk dlm urutan yg benar
                                         //tukar ekemen
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            }
        }
    }
        static void Main(String[] args)
        {
            //creating the object of the bubblesort class
            Program myList = new Program();
            //pemanggilan fungsi untuk menerima panggilan array
            myList.read();
            //pemanggilan fungsi utk mengurutkan array
            myList.BubbleSortArray();
            //pemanggilan fungsi utk menampilkan array yg tersusun
            myList.display();
            //exit
            Console.WriteLine("\n\n Tekan Tombol Apa Saja Untk Keluar.");
            Console.Read();

        }
    }

