using System;
using System.Runtime.CompilerServices;

namespace Soal
{
    public class Agen
    {
        public string idAgen;
        public string namaAgen;
        public int stokAgen;


        public void TampilkanInfo()
        {
            Console.WriteLine($"{idAgen}, {namaAgen}, {stokAgen}");
        }

    }

    public class ProdukGalon
    {
        private string idProduk;
        private string namaProduk;
        private string stokGudang;
        
    }

    public class GalonAkua : ProdukGalon
    {
        public int harga = 20000;              
    }

    public class GalonBerkeran : ProdukGalon
    {
        public int harga = 12000;      
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Agen Agen1 = new Agen();
            Agen1.idAgen = "A1";
            Agen1.namaAgen = "PT aqua";
            Agen1.stokAgen = 100;

            Agen1.TampilkanInfo();

            Agen Agen2 = new Agen();
            Agen2.idAgen = "A2";
            Agen2.namaAgen = "PT Crystaline";
            Agen2.stokAgen = 100;

            Agen2.TampilkanInfo();

        }
    }
}