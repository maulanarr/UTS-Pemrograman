using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utsmaulana
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen(1, "Maulana Rizky Rahmadhani", 21114465, "Laki-laki", "Pemrograman");

            dosen1.cetakHasil();
            Console.WriteLine();
            dosen1.addDosen();
            dosen1.addCourse();
            Console.WriteLine();
            dosen1.cetakAkhir();

            Console.ReadKey();
        }
    }
}

