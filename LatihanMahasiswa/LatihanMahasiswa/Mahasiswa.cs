using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMahasiswa
{
    public class Mahasiswa
    {
        public Mahasiswa()
        {

        }

        public Mahasiswa(string nim, string nama)
        {
            nim = nim;
            nama = nama;
        }

        public string Nim { get; set; }
        public string Nama { get; set; }
          
    }
}
