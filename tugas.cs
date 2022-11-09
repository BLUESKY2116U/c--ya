
namespace NichiCompany {
    public class NichiCodex
    {
        public static void Main()
        {   
            Console.Clear();
            Console.WriteLine(" ______________________________________________________________ ");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|                         NichiCompany                         |");
            Console.WriteLine("|                Jl. Veteran No. 1A, Tangerang                 |");
            Console.WriteLine("|______________________________________________________________|");
            Console.Write(" Nama Bangunan: ");
            string nb = Console.ReadLine();
            if(nb == "")
            {
                Console.Clear();
                Console.WriteLine(" ______________________________________________________________ ");
                Console.WriteLine("|                                                              |");
                Console.WriteLine("|                         NichiCompany                         |");
                Console.WriteLine("|                Jl. Veteran No. 1A, Tangerang                 |");
                Console.WriteLine("|______________________________________________________________|");
                Console.Write(" Masukkan Barang!.");
                System.Environment.Exit(1);
            }
            Console.Write(" Jumlah: ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            if (nb == "Jendela")
            {
                var hargaBarang = 350000;
                var harga = hargaBarang * jumlah;
                Console.WriteLine($" Harga: IDR {hargaBarang}");
                Console.WriteLine($" Total: IDR {harga}");
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine(" Diskon: 30%");
                var disc = 0.3 * harga;
                var totalHarga = harga - disc;
                Console.WriteLine($" Total Harga: IDR { totalHarga }");
                Console.WriteLine("________________________________________________________________");
                Console.Write(" Jumlah Bayar: IDR ");
                int jb = Convert.ToInt32(Console.ReadLine());
                var kembalian = jb - totalHarga;
                Console.WriteLine($" Kembalian: IDR { kembalian }");
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine(" Terima Kasih sudah Berbelanja di NichiCompany");
            } else if (nb == "Pintu")
            {
                var hargaBarang = 300000;
                var harga = hargaBarang * jumlah;
                Console.WriteLine($" Harga: IDR {hargaBarang}");
                Console.WriteLine($" Total: IDR {harga}");
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine(" Diskon: 30%");
                var disc = 0.3 * harga;
                var totalHarga = harga - disc;
                Console.WriteLine($" Total Harga: IDR { totalHarga }");
                Console.WriteLine("________________________________________________________________");
                Console.Write(" Jumlah Bayar: IDR ");
                int jb = Convert.ToInt32(Console.ReadLine());
                var kembalian = jb - totalHarga;
                Console.WriteLine($" Kembalian: IDR { kembalian }");
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine(" Terima Kasih sudah Berbelanja di NichiCompany");
            } else {
                Console.Clear();
                Console.WriteLine(" ______________________________________________________________ ");
                Console.WriteLine("|                                                              |");
                Console.WriteLine("|                         NichiCompany                         |");
                Console.WriteLine("|                Jl. Veteran No. 1A, Tangerang                 |");
                Console.WriteLine("|______________________________________________________________|");
                Console.Write(" Barang Tidak Ditemukan!.");
                System.Environment.Exit(1);
            }
        }
    }
}
