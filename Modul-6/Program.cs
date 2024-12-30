using System;

class Program 
{
    // Fungsi void untuk memeriksa bil ganjil atau genap
    static void PeriksaGanjilGenap(int bil) {
        
        // Menggunakan operator modulo untuk memeriksa
        if (bil % 2 == 0) {
            Console.WriteLine($"{bil} adalah bil genap");
        }
        else {
            Console.WriteLine($"{bil} adalah bil ganjil");
        }
    }
    // Contoh penggunaan di method Main
    static void Main(string[] args)
    {
        // Memanggil fungsi dengan beberapa contoh bil
        PeriksaGanjilGenap(10);
        PeriksaGanjilGenap(7);
        PeriksaGanjilGenap(0);
        PeriksaGanjilGenap(-3);
    }
}

//-----------------------------------------------------------

// using System;

// class Program 
// {
//     static int hitungKuadrat(int x) => x * x;

//     static void Main()
//     {
//         Console.WriteLine(hitungKuadrat(5));
//     }
// }
