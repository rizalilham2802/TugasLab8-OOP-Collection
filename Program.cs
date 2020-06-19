using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugaslab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) Inheritance, Polymorphsim, Abstraction & Collection ";

            //membuat object untuk semua karyawan
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-234-345";
            karyawanTetap.Nama = "Michael suyawa";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-321-346";
            karyawanHarian.Nama = "Laura callahan";
            karyawanHarian.JumlahJamKerja = 8 ;
            karyawanHarian.UpahPerJam = 13000 ;

            Seles seles = new Seles();
            seles.Nik = "123-333-347";
            seles.Nama = "Andrew Fuller";
            seles.JumlahPenjualan = 30;
            seles.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(seles);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
 
            }
            Console.ReadKey();
        }
    }
}
