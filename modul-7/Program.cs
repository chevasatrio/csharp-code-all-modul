class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan berat barang (kg): ");
        int bobot = Convert.ToInt32(Console.ReadLine());

        if (bobot <= 0) {
            Console.WriteLine("Berat harus bilangan bulat positif.");
        }
        else {
            int totalBiaya = HitungBiayaPengiriman(bobot);
            Console.WriteLine("Total biaya pengiriman adalah: Rp. " + totalBiaya);
        }
    }

    static int HitungBiayaPengiriman(int bobot)
    {
        if (bobot == 1) {
            return 10000;
        }
        else if (bobot > 1 && bobot <= 5) {
            return 10000 + (bobot - 1) * 7500;
        }
        else {
            return 10000 + (4 * 7500) + (bobot - 5) * 5000;
        }
    }
}